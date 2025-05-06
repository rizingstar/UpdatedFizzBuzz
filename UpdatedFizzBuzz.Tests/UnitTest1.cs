using NUnit.Framework;

namespace UpdatedFizzBuzz.Tests
{
    [TestFixture]
    public class FizzBuzzTests
    {
        [Test]
        public void ReturnsEmptyString_WhenInputIsLessThanOne()
        {
            Assert.That(Challenge.FizzBuzz(0), Is.EqualTo(""));
            Assert.That(Challenge.FizzBuzz(-10), Is.EqualTo(""));
        }

        [Test]
        public void ReturnsSingleValue_WhenInputIsOne()
        {
            Assert.That(Challenge.FizzBuzz(1), Is.EqualTo("1"));
        }

        [Test]
        public void ReplacesMultiplesOf3_WithFizz()
        {
            Assert.That(Challenge.FizzBuzz(3), Is.EqualTo("1\n2\nFizz"));
        }

        [Test]
        public void ReplacesMultiplesOf5_WithBuzz()
        {
            Assert.That(Challenge.FizzBuzz(5), Is.EqualTo("1\n2\nFizz\n4\nBuzz"));
        }

        [Test]
        public void ReplacesMultiplesOf3And5_WithFizzBuzz()
        {
            Assert.That(Challenge.FizzBuzz(15), Is.EqualTo("1\n2\nFizz\n4\nBuzz\nFizz\n7\n8\nFizz\nBuzz\n11\nFizz\n13\n14\nFizzBuzz"));
        }

        [Test]
        public void DoesNotHaveTrailingNewline()
        {
            string output = Challenge.FizzBuzz(5);
            Assert.That(output.EndsWith('\n'), Is.False, "Output should not have a trailing newline.");
        }
    }
}
