namespace TestLeetCode206
{
    public class Tests
    {
        Solution Solution { get; set; }
        [SetUp]
        public void Setup()
        {
            Solution = new();
        }

        [Test]
        public void TestNormalCase1()
        {
            var head = new ListNode([6,9,12,46]);
            var answer = new ListNode([46,12,9,6]);
            Solution.ReverseList(head);

            while (head != null)
            {
                Assert.That(head.val, Is.EqualTo(answer.val));
                head = head.next;
                answer = answer.next;
            }
        }

        [Test]
        public void TestNormalCase2()
        {
            var head = new ListNode([47,-6,12,0,8]);
            var answer = new ListNode([8,0,12,-6,47]);
            Solution.ReverseList(head);

            while (head != null)
            {
                Assert.That(head.val, Is.EqualTo(answer.val));
                head = head.next;
                answer = answer.next;
            }
        }

        [Test]
        public void TestSmallArray1()
        {
            var head = new ListNode([0]);
            var answer = new ListNode([0]);
            Solution.ReverseList(head);

            while (head != null)
            {
                Assert.That(head.val, Is.EqualTo(answer.val));
                head = head.next;
                answer = answer.next;
            }
        }

        [Test]
        public void TestSmallArray2()
        {
            var head = new ListNode([0,1]);
            var answer = new ListNode([1,0]);
            Solution.ReverseList(head);

            while (head != null)
            {
                head = head.next;
                answer = answer.next;
            }
        }

        [Test]
        public void TestNullCase()
        {
            ListNode head = null;
            ListNode answer = null;
            Assert.That(answer, Is.EqualTo(Solution.ReverseList(head)));

        }
    }
}
