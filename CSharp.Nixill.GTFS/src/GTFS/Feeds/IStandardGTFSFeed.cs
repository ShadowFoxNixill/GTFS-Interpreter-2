using Nixill.GTFS.Collections;
using Nixill.GTFS.Entities;

namespace Nixill.GTFS.Feeds
{
  public interface IStandardGTFSFeed : IGTFSFeed
  {
    public IDEntityCollection<FareAttribute> FareAttributes { get; }
  }
}