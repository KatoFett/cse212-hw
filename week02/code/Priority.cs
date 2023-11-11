/*
 * CSE212 
 * (c) BYU-Idaho
 * 02-Prove - Problem 2
 * 
 * It is a violation of BYU-Idaho Honor Code to post or share this code with others or 
 * to post it online.  Storage into a personal and private repository (e.g. private
 * GitHub repository, unshared Google Drive folder) is acceptable.
 *
 */
public static class Priority {
    public static void Test() {
        // TODO Problem 2 - Write and run test cases and fix the code to match requirements

        // Test Cases

        // Test 1
        // Scenario: Enqueue three values to ensure enqueueing works as intended.
        // Expected Result: a, b, c
        Console.WriteLine("Test 1");
        var priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 2);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 0);
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: None.

        Console.WriteLine("---------");

        // Test 2
        // Scenario: Dequeue the first value.
        // Expected Result: b, c
        Console.WriteLine("Test 2");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 2);
        priorityQueue.Enqueue("b", 1);
        priorityQueue.Enqueue("c", 0);

        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Element not being removed from the queue.

        Console.WriteLine("---------");

        // Test 3
        // Scenario: Dequeue the highest priority in the middle.
        // Expected Result: a, c
        Console.WriteLine("Test 3");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("a", 0);
        priorityQueue.Enqueue("b", 2);
        priorityQueue.Enqueue("c", 1);

        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: 

        Console.WriteLine("---------");

        // Test 4
        // Scenario: Dequeue the first of equal priorities.
        // Expected Result: first, third, fourth, fifth
        Console.WriteLine("Test 4");
        priorityQueue = new PriorityQueue();
        priorityQueue.Enqueue("first", 0);
        priorityQueue.Enqueue("second", 2);
        priorityQueue.Enqueue("third", 1);
        priorityQueue.Enqueue("fourth", 2);
        priorityQueue.Enqueue("fifth", 2);

        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

        // Defect(s) Found: Not getting the first of the highest priority, and skipping the last element.

        Console.WriteLine("---------");

        // Test 5
        // Scenario: Error when queue is empty.
        // Expected Result: Error message is displayed.
        Console.WriteLine("Test 5");
        priorityQueue = new PriorityQueue();
        priorityQueue.Dequeue();
        Console.WriteLine(priorityQueue);

    }
}