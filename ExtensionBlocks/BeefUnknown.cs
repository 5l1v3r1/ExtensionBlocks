﻿using System.Text;

namespace ExtensionBlocks
{
    public class BeefUnknown : BeefBase
    {
        public BeefUnknown(byte[] rawBytes)
            : base(rawBytes)
        {
            Message =
                "********UNKNOWN Extension block. Please report to Report to saericzimmerman@gmail.com to get it added!";
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            return sb.ToString();
        }
    }
}