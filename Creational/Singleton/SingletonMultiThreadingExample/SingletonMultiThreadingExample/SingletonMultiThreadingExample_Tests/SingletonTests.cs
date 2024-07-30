using FluentAssertions;
using SingletonMultiThreadingExample.Classes;
using SingletonMultiThreadingExample.Interfaces;

namespace SingletonMultiThreadingExample_Tests
{
    [TestFixture]
    public class SingletonTests
    {
        [Test]
        public void SingletonWithLock_ShouldReturnSameInstance()
        {
            // Arrange & Act
            var instance1 = SingletonWithLock.Instance;
            var instance2 = SingletonWithLock.Instance;

            // Assert
            instance1.Should().BeSameAs(instance2);
        }

        [Test]
        public void SingletonWithLazy_ShouldReturnSameInstance()
        {
            // Arrange & Act
            var instance1 = SingletonWithLazy.Instance;
            var instance2 = SingletonWithLazy.Instance;

            // Assert
            instance1.Should().BeSameAs(instance2);
        }

        [Test]
        public void SingletonWithLock_ShouldBeThreadSafe()
        {
            // Arrange
            ISingleton[] instances = new ISingleton[10];

            // Act
            Parallel.For(0, 10, i =>
            {
                instances[i] = SingletonWithLock.Instance;
            });

            // Assert
            foreach (var instance in instances)
            {
                instance.Should().BeSameAs(SingletonWithLock.Instance);
            }
        }

        [Test]
        public void SingletonWithLazy_ShouldBeThreadSafe()
        {
            // Arrange
            ISingleton[] instances = new ISingleton[10];

            // Act
            Parallel.For(0, 10, i =>
            {
                instances[i] = SingletonWithLazy.Instance;
            });

            // Assert
            foreach (var instance in instances)
            {
                instance.Should().BeSameAs(SingletonWithLazy.Instance);
            }
        }

        [Test]
        public void NonThreadSafeSingleton_ShouldNotBeThreadSafe()
        {
            // Arrange
            ISingleton[] instances = new ISingleton[10];

            // Act
            Parallel.For(0, 10, i =>
            {
                instances[i] = NonThreadSafeSingleton.Instance;
            });

            // Assert
            //instances.Should().OnlyContain(instance => instance == instances[0]);
            instances.Distinct().Should().HaveCountGreaterThan(1, "because there should be different instances if the singleton is not thread-safe");
        }
    }
}