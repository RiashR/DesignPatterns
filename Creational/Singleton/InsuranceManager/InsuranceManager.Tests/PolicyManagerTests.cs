using FluentAssertions;
using InsuranceManager.Classes;
using InsuranceManager.Enums;
using InsuranceManager.Models;

namespace InsuranceManager.Tests
{
    [TestFixture]
    public class PolicyManagerTests
    {
        [Test]
        public void SingletonInstance_ShouldBeShared()
        {
            // Arrange
            var instance1 = PolicyManager.Instance;
            var instance2 = PolicyManager.Instance;

            // Assert
            instance1.Should().BeSameAs(instance2);
        }

        [Test]
        public void GetPolicy_ShouldReturnCorrectPolicy()
        {
            // Arrange
            var instance = PolicyManager.Instance;
            instance.Policies.Clear();

            var policy = new Policy(2, new PolicyHolder("Name", "Surname"), 5000.00, InsuranceType.Car, PolicyType.Premium);
            instance.AddPolicy(policy);

            // Act
            var retrievedPolicy = instance.GetPolicy(2);

            // Assert
            retrievedPolicy.Should().Be(policy);
        }

        [Test]
        public void AddPolicy_ShouldAddPolicyToList()
        {
            // Arrange
            var instance = PolicyManager.Instance;
            instance.Policies.Clear();

            var policy = new Policy(4, new PolicyHolder("John", "Doe"), 5000.00, InsuranceType.Home, PolicyType.Basic); ;

            // Act
            instance.AddPolicy(policy);

            // Assert
            instance.Policies.Should().Contain(policy);
        }

        [Test]
        public void GetPolicy_ShouldReturnNullIfPolicyNotFound()
        {
            // Arrange
            var instance = PolicyManager.Instance;
            instance.Policies.Clear();

            // Act
            var retrievedPolicy = instance.GetPolicy(999);

            // Assert
            retrievedPolicy.Should().BeNull();
        }
    }
}

