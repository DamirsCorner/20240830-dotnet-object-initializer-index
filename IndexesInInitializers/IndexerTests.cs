using FluentAssertions;

namespace IndexesInInitializers;

public class IndexerTests
{
    [Test]
    public void DictionaryInitializer()
    {
        var dictionary = new Dictionary<int, string>
        {
            [1] = "one",
            [2] = "two",
            [3] = "three",
        };

        dictionary[1].Should().Be("one");
        dictionary[2].Should().Be("two");
        dictionary[3].Should().Be("three");
    }

    [Test]
    public void InitializersBeforeCs13()
    {
        var thing = new IndexersExample
        {
            name = "object one",
            [1] = '1',
            [2] = '4',
            [3] = '9',
            Size = Math.PI,
        };

        thing.name.Should().Be("object one");
        thing[1].Should().Be('1');
        thing[2].Should().Be('4');
        thing[^1].Should().Be('9');
        thing.Size.Should().Be(Math.PI);
    }

    [Test]
    public void InitializersSinceCs13()
    {
        var thing = new IndexersExample
        {
            name = "object one",
            [1] = '1',
            [2] = '4',
            [^1] = '9',
            Size = Math.PI,
        };

        thing.name.Should().Be("object one");
        thing[1].Should().Be('1');
        thing[2].Should().Be('4');
        thing[^1].Should().Be('9');
        thing.Size.Should().Be(Math.PI);
    }
}
