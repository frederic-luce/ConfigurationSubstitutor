namespace ConfigurationSubstitution
{
    using System;

    public class LoopDetectedException : Exception
    {
        public LoopDetectedException(string variableName)
            : base($"Loop detected for configuration variable {variableName}")
        {
        }
    }

}