using Library;

namespace Visitor
{
    public abstract class Visitor
    {
        public abstract void Visit (Person persona);
        public abstract void Visit (Node node);
    }
}