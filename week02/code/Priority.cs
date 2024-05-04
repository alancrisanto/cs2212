public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements
        // Example of creating and using the priority queue
        var priorityQueue = new PriorityQueue();

        // Test Cases
        // Test 1
        // Scenario: Create a queue with the following priority:
        // ("A", 3), ("B", 2), ("C", 1)
        // Expected result: A, B, C
        priorityQueue.Enqueue("A", 3);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 1);

        // Expected Result: 
        Console.WriteLine("Test 1");
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());

        // Defect(s) Found: 
        // Result obtained: A, A, A, A, A, A

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Create a queue with more than one item with th highest priority
        // Expected Result: A,A, B, B, C, C
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("A", 2);
        priorityQueue.Enqueue("B", 2);
        priorityQueue.Enqueue("C", 2);

        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        Console.WriteLine(priorityQueue.Dequeue());
        // Defect(s) Found: 
        // Result obtained: B, B, B, B, B, B
        Console.WriteLine("---------");

        // Add more Test Cases As Needed Below
    }
}