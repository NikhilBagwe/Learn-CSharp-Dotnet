## Intro :

- The concept of Stacks and Heaps is connected to Value and Reference types.
- Once we execute a program, certains variables are created and some memory is allocated to them depending upon their type.
- Once the execution finishes we want the memory occupied by the variables to be cleaned and given back to OS.
- To make this happen internally, the memory is organised into 2 sections : Stack and Heap.

## Stack :

- Value types are stored in Stack.
- Stack works on the concept of LIFO.
- So all the variables we create in our program are stored here.
- In case of object, the address pointing to the memory location in Heap i.e Pointer is stored in Stack.
- Now the data is stored in a organized manner, it is easy for the pgm to just deallocate the stack to claim back the memory once pgm is executed.

## Heap :

- Refernece types are stored in Heap.

## Garbage collector :

- When pgm execution finishes, stack gets deallocated. But what about Heap? Who cleans it? ==> Garbage collector.
- Garbage collector is a background process in .NET framework which comes and sees that this is the data in heap, but the pointer pointing to it are deallocated.
- Thus, the memory not having any reference in stack is deallocated from heap by Garbage collector and given back to OS.
