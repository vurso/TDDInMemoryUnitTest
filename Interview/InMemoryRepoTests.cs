using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interview
{
    [TestFixture]
    public class InMemoryRepoTests
    {
        private IEnumerable<StorageStub> storageData;

        [OneTimeSetUp]
        public void Setup()
        {
            storageData = new[] { new StorageStub(1), new StorageStub(12), new StorageStub(39) };
        }

        [Test]
        public void Given_Repository_Then_Get_All_Data()
        {
            var repo = new Repository<StorageStub>(storageData);
        }

        public class StorageStub : IStoreable<int>
        {
            public StorageStub(int id)
            {
                Id = id;
            }

            public int Id { get; set; }
        }
    }
}