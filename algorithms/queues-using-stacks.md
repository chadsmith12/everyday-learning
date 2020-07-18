## Implement Queues Using Stacks

A Queue is an abstract data type. It says that at the very least you will support the `Enqueue` and `Dequeue` operations. A Queue is a FIFO Data Structure in that the first item put in will be the first item out.

When implementing a Queue using stacks you will notice a barrier. A stack is a First In Last Out data structure. So how do we implement a Queue using a stack?

### Naive Implementation
The first implementation you will try is having a stack. When you `Enqueue` into the Queue then you end up pusing onto the stack. Though what happens when you try to `Dequeue` from the queue? You will notice that the first item is at the bottom of the stack. You would have to pop all the items off. After you pop all items off, you would then have to put all the items back onto the stack. This is going to be  `O(n)`. We can actually end up doing better than this. 

### Better Implementation
You will notice that with the stack implementation that a `Dequeue` operation ends up putting all the items in the correct order. This means the next time you do a `Dequeue` operation, you could actually just take the top item. That means that the 2nd list is actually a stack too. So you could have two stacks: a `pushStack` and `popStack`. When the `popStack` is not empty, then you could just pop from that stack.

The `Enqueue` operation is as it was before.  You just end up doing a `Push` operation on on the `pushStack`. So therefore calling `Enqueue(5)` would be internally doing a `pushStack.Push(5)`.

The `Dequeue` operation first needs to check if the `popStack` has any items. If it does then we could pop from that stack using `popStack.Pop()`. Though what if the `popStack` is empty? For this, we would end up popping everything off the `pushStack` until it is empty. Then from there we will pop the last time added to the `popStack`. While when the `popStack` is empty we end up doing a `O(n)` operation, though we end up doing a `O(1)` operation when the `popStack` is not empty. From there we could generalize that most common uses for a `Dequeue` would end up being `O(1)`.
