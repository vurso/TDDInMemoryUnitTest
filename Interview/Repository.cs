using System.Collections.Generic;

namespace Interview
{
    public class Repository<StorageStub>
    {
        private IEnumerable<InMemoryRepoTests.StorageStub> storageData;

        public Repository()
        {
        }

        public Repository(IEnumerable<InMemoryRepoTests.StorageStub> storageData)
        {
            this.storageData = storageData;
        }
    }
}
