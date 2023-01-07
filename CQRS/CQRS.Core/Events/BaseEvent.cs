using CQRS.Core.Messages;
namespace CQRS.Core.Events;

public abstract class BaseEvent : Message
{
   // to make sure that all our events objects pass their type to the base event type 
   protected BaseEvent(string type)
   {
      this.Type = type;
   }
   // we need a version property, when we check to replay for the latest state of our aggregate
   public int Version { get; set; }

   // we need the type of the event 
   public string Type { get; set; }
}