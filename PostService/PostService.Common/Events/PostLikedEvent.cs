using CQRS.Core.Events;


namespace PostService.Common.Events;

public class PostLikedEvent: BaseEvent
{
    public PostLikedEvent():base(typeof(PostLikedEvent))
    {
        
    }    
}