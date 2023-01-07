using CQRS.Core.Events;
namespace PostService.Common.Events;

public class PostDeletedEvent: BaseEvent
{
    public PostDeletedEvent(): base(typeof(PostDeletedEvent))
    {
        
    }
    // we don't need the post id because at this stage we already know which post we are handling
} 