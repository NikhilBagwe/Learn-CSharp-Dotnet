## 37

```csharp
public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
public RepositoryContext CreateDbContext(string[] args)
{
var configuration = new ConfigurationBuilder()
.SetBasePath(Directory.GetCurrentDirectory())
.AddJsonFile("appsettings.json")
.Build();
var builder = new DbContextOptionsBuilder<RepositoryContext>()
.UseSqlServer(configuration.GetConnectionString("sqlConnection"));
return new RepositoryContext(builder.Options);
}
}
```

## 39

```csharp
var builder = new DbContextOptionsBuilder<RepositoryContext>()
.UseSqlServer(configuration.GetConnectionString("sqlConnection"),
b => b.MigrationsAssembly("CompanyEmployees"));
```

## 40, 41

```csharp
public class CompanyConfiguration : IEntityTypeConfiguration<Company>
{
 public void Configure(EntityTypeBuilder<Company> builder)
 {
 builder.HasData
 (
 new Company
 {
 Id = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870"),
 Name = "IT_Solutions Ltd",
 Address = "583 Wall Dr. Gwynn Oak, MD 21207",
 Country = "USA"
 },
 new Company
 {
 Id = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3"),
 Name = "Admin_Solutions Ltd",
 Address = "312 Forest Avenue, BF 923",
 Country = "USA"
 }
 );
 }
}


public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
{
 public void Configure(EntityTypeBuilder<Employee> builder)
 {
 builder.HasData
 (
 new Employee
 {
 Id = new Guid("80abbca8-664d-4b20-b5de-024705497d4a"),
 Name = "Sam Raiden",
 Age = 26,
 Position = "Software developer",
 CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
 },
 new Employee
 {
 Id = new Guid("86dba8c0-d178-41e7-938c-ed49778fb52a"),
 Name = "Jana McLeaf",
 Age = 30,
 Position = "Software developer",
 CompanyId = new Guid("c9d4c053-49b6-410c-bc78-2d54a9991870")
 },
 new Employee
 {
 Id = new Guid("021ca3c1-0deb-4afd-ae94-2159a8479811"),
 Name = "Kane Miller",
 Age = 35,
 Position = "Administrator",
 CompanyId = new Guid("3d490a70-94ce-4d15-9494-5248280c2ce3")
 }
 );
 }
}


public class RepositoryContext: DbContext
{
 public RepositoryContext(DbContextOptions options)
 : base(options)
 {
 }
 protected override void OnModelCreating(ModelBuilder modelBuilder)
 {
 modelBuilder.ApplyConfiguration(new CompanyConfiguration());
 modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
 }
 public DbSet<Company> Companies { get; set; }
 public DbSet<Employee> Employees { get; set; }
}
```

## 42, 43

```csharp
public interface IRepositoryBase<T>
{
 IQueryable<T> FindAll(bool trackChanges);
 IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
 bool trackChanges);
 void Create(T entity);
 void Update(T entity);
 void Delete(T entity);
}


public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
{
 protected RepositoryContext RepositoryContext;
 public RepositoryBase(RepositoryContext repositoryContext)
 => RepositoryContext = repositoryContext;

 public IQueryable<T> FindAll(bool trackChanges) =>
 !trackChanges ?
 RepositoryContext.Set<T>()
 .AsNoTracking() :
 RepositoryContext.Set<T>();
 public IQueryable<T> FindByCondition(Expression<Func<T, bool>> expression,
 bool trackChanges) =>
 !trackChanges ?
 RepositoryContext.Set<T>()
 .Where(expression)
 .AsNoTracking() :
 RepositoryContext.Set<T>()
 .Where(expression);
 public void Create(T entity) => RepositoryContext.Set<T>().Add(entity);
 public void Update(T entity) => RepositoryContext.Set<T>().Update(entity);
 public void Delete(T entity) => RepositoryContext.Set<T>().Remove(entity);
}
```

## 46

```csharp
public sealed class RepositoryManager : IRepositoryManager
{
private readonly RepositoryContext _repositoryContext;
private readonly Lazy<ICompanyRepository> _companyRepository;
private readonly Lazy<IEmployeeRepository> _employeeRepository;
public RepositoryManager(RepositoryContext repositoryContext)
{
_repositoryContext = repositoryContext;
_companyRepository = new Lazy<ICompanyRepository>(() => new
CompanyRepository(repositoryContext));
_employeeRepository = new Lazy<IEmployeeRepository>(() => new
EmployeeRepository(repositoryContext));
}
public ICompanyRepository Company => _companyRepository.Value;
public IEmployeeRepository Employee => _employeeRepository.Value;
public void Save() => _repositoryContext.SaveChanges();
}

```

## 48, 49

```csharp
using Contracts;
using Service.Contracts;
namespace Service
{
internal sealed class CompanyService : ICompanyService
{
private readonly IRepositoryManager _repository;
private readonly ILoggerManager _logger;
public CompanyService(IRepositoryManager repository, ILoggerManager
logger)
{
_repository = repository;
_logger = logger;
}
}
}


using Contracts;
using Service.Contracts;
namespace Service
{
internal sealed class EmployeeService : IEmployeeService
{
private readonly IRepositoryManager _repository;
private readonly ILoggerManager _logger;
public EmployeeService(IRepositoryManager repository, ILoggerManager
logger)
{
_repository = repository;
_logger = logger;
}
}
}


public sealed class ServiceManager : IServiceManager
{
private readonly Lazy<ICompanyService> _companyService;
private readonly Lazy<IEmployeeService> _employeeService;
public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager
logger)
{
_companyService = new Lazy<ICompanyService>(() => new
CompanyService(repositoryManager, logger));
_employeeService = new Lazy<IEmployeeService>(() => new
EmployeeService(repositoryManager, logger));
}
public ICompanyService CompanyService => _companyService.Value;
public IEmployeeService EmployeeService => _employeeService.Value;
}
```

## 51

```csharp
public static void ConfigureSqlContext(this IServiceCollection services,
IConfiguration configuration) =>
services.AddDbContext<RepositoryContext>(opts =>
opts.UseSqlServer(configuration.GetConnectionString("sqlConnection")));

public static void ConfigureSqlContext(this IServiceCollection services,
IConfiguration configuration) =>
services.AddSqlServer<RepositoryContext>((configuration.GetConnectionString("sq
lConnection")));
```

## 37

```csharp
```









































