using Microsoft.VisualStudio.TestTools.UnitTesting;

// TODO Problem 2 - Write and run test cases and fix the code to match requirements.

[TestClass]
public class PriorityQueueTests
{
    [TestMethod]
    // Scenario: Enqueue three items with different priorities: A(1), B(5), C(3). Dequeue once.
    // Expected Result: B (highest priority 5) is removed and returned
    // Defect(s) Found: The loop in Dequeue skips the last element, so if the highest priority is at the end, it is ignored.
    public void TestPriorityQueue_1()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    [TestMethod]
    // Scenario: Enqueue two items with equal priority: A(5), B(5). Dequeue once.
    // Expected Result: A is removed first (FIFO order for ties).
    // Defect(s) Found: The comparison in Dequeue uses >=, which incorrectly selects the last item instead of the first when priorities are equal.
    public void TestPriorityQueue_2()
    {
        var priorityQueue = new PriorityQueue();
        Assert.Fail("Implement the test case and then remove this.");
    }

    // Add more test cases as needed below.
    
    [TestMethod]
// Scenario: Enqueue three items with different priorities: A(1), B(5), C(3). Dequeue once.
// Expected Result: B (highest priority 5) is removed and returned.
// Defect(s) Found: If Dequeue does not correctly find the highest priority item.
public void TestPriorityQueue_HighestPriority()
{
    var pq = new PriorityQueue();
    pq.Enqueue("A", 1);
    pq.Enqueue("B", 5);
    pq.Enqueue("C", 3);

    var result = pq.Dequeue();
    Assert.AreEqual("B", result);
}

[TestMethod]
// Scenario: Enqueue two items with equal priority: A(5), B(5). Dequeue once.
// Expected Result: A is removed first (FIFO order).
// Defect(s) Found: If Dequeue removes B instead of A.
public void TestPriorityQueue_TieBreaker()
{
    var pq = new PriorityQueue();
    pq.Enqueue("A", 5);
    pq.Enqueue("B", 5);

    var result = pq.Dequeue();
    Assert.AreEqual("A", result);
}
[TestMethod]
// Scenario: Call Dequeue on an empty queue.
// Expected Result: InvalidOperationException with message "The queue is empty."
// Defect(s) Found: If no exception is thrown, or wrong exception/message is used.
public void TestPriorityQueue_EmptyQueue()
{
    var pq = new PriorityQueue();

    try
    {
        pq.Dequeue();
        Assert.Fail("Exception should have been thrown.");
    }
    catch (InvalidOperationException e)
    {
        Assert.AreEqual("The queue is empty.", e.Message);
    }
}

}