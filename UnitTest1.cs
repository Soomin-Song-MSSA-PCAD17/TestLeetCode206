namespace TestLeetCode206
{
    public class Tests
    {
        Solution Solution { get; set; }
        ListNode input { get; set; }
        ListNode expectedOutput { get; set; }
        [SetUp]
        public void Setup()
        {
            Solution = new();
        }

        [Test]
        public void TestNormalCase1()
        {
            input = new ListNode([6,9,12,46]);
            expectedOutput = new ListNode([46,12,9,6]);
            Solution.ReverseList(input);

            while (input != null)
            {
                Assert.That(input.val, Is.EqualTo(expectedOutput.val));
                input = input.next;
                expectedOutput = expectedOutput.next;
            }
        }

        [Test]
        public void TestNormalCase2()
        {
            input = new ListNode([47,-6,12,0,8]);
            expectedOutput = new ListNode([8,0,12,-6,47]);
            Solution.ReverseList(input);

            while (input != null)
            {
                Assert.That(input.val, Is.EqualTo(expectedOutput.val));
                input = input.next;
                expectedOutput = expectedOutput.next;
            }
        }

        [Test]
        public void TestSmallArray1()
        {
            input = new ListNode([0]);
            expectedOutput = new ListNode([0]);
            Solution.ReverseList(input);

            while (input != null)
            {
                Assert.That(input.val, Is.EqualTo(expectedOutput.val));
                input = input.next;
                expectedOutput = expectedOutput.next;
            }
        }

        [Test]
        public void TestSmallArray2()
        {
            input = new ListNode([0,1]);
            expectedOutput = new ListNode([1,0]);
            Solution.ReverseList(input);

            while (input != null)
            {
                input = input.next;
                expectedOutput = expectedOutput.next;
            }
        }

        [Test]
        public void TestNullCase()
        {
            input = null;
            expectedOutput = null;
            Assert.That(expectedOutput, Is.EqualTo(Solution.ReverseList(input)));

        }
    }
}
