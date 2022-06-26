namespace ADHDTool.Models
{
    public class BucketlistService
    {
        private List<BucketListEntry> _bucketListEntrys = new List<BucketListEntry>();
        public List<BucketListEntry> GetBucketList()
        {
            return _bucketListEntrys;
        }
        public void addBucketListEntry(string titel)
        {
            var entry = new BucketListEntry();
            entry.Titel = titel;
            entry.ID = _bucketListEntrys.Count + 1;
            entry.IsChecked = false;
            _bucketListEntrys.Add(entry);
        }
        public void removeBucketListEntry(BucketListEntry entry)
        {
            _bucketListEntrys.Remove(entry);
        }
    }
}
