using ClassLibraryBehavioralPatterns.Observer;

namespace ClassLibraryStructurePatterns.Composite.Classes
{
    public abstract class LightNode : EventTarget
    {
        public abstract string InnerHTML();
        public abstract string OuterHTML();
    }
}
