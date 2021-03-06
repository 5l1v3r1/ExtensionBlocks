﻿using System;
using System.Linq;
using System.Text;

namespace ExtensionBlocks
{
    public class Beef0027 : BeefBase
    {
        public Beef0027(byte[] rawBytes)
            : base(rawBytes)
        {
            if (Signature != 0xbeef0027)
            {
                throw new Exception($"Signature mismatch! Should be 0xbeef0027 but is {Signature}");
            }

            var propStore = new PropertyStore(rawBytes.Skip(8).ToArray());


            PropertyStore = propStore;


            VersionOffset = BitConverter.ToInt16(rawBytes, rawBytes.Length - 2);
        }

        public PropertyStore PropertyStore { get; }


        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());

            var sheetNumber = 0;

            foreach (var propertySheet in PropertyStore.Sheets)
            {
                sb.AppendLine($"Sheet #{sheetNumber} => {propertySheet}");

                sheetNumber += 1;
            }


            return sb.ToString();
        }
    }
}