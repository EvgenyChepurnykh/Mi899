﻿using Mi899.Data;

namespace Mi899.Domain
{
    internal class Motherboard : IMotherboard
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Version { get; set; }
        public string[] Tags { get; set; }
        public string Description { get; set; }
        public Link[] Images { get; set; }
        public Link[] Links { get; set; }
        public string[] ToolIds { get; set; }
        ILink[] IMotherboard.Images => Images;
        ILink[] IMotherboard.Links => Links;
    }
}
