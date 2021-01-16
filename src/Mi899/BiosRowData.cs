﻿using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using Mi899.Data;

namespace Mi899
{
    public class BiosRowData : IBios
    {
        public BiosRowData([NotNull] IBios source)
        {
            Source = source ?? throw new ArgumentNullException(nameof(source));
        }

        public IBios Source { get; protected set; }

        public string Id => Source.Id;

        public string Name => Source.Name;

        public string[] MotherboardIds => Source.MotherboardIds;

        public string Description => Source.Description;

        public string[] Tags => Source.Tags;

        public string TagsString => string.Join(", ", Tags);

        public string FileName => Source.FileName;

        public bool IsZipped => Source.IsZipped;

        public IReadOnlyDictionary<string, string> Properties => Source.Properties;

        public string PropertiesString
        {
            get
            {
                return Source.Properties == null 
                    ? string.Empty 
                    : string.Join(Environment.NewLine, Properties.Select(x => $"{x.Key}: {x.Value}."));
            }
        }

        public string[] Chipsets => Source.Chipsets;

        public string ChipsetsStrings => string.Join(", ", Chipsets);
    }
}
