﻿using EnsureThat;

namespace MyCouch.Requests
{
    public class DeleteIndexRequest : Request
    {
        public string DesignDoc { get; private set; }
        public string Name { get; private set; }
        public IndexType Type { get; private set; }

        public DeleteIndexRequest(string designDoc, string name, IndexType type = IndexType.Json)
        {
            EnsureArg.IsNotNullOrWhiteSpace(designDoc, nameof(designDoc));
            EnsureArg.IsNotNullOrWhiteSpace(name, nameof(name));

            DesignDoc = designDoc;
            Name = name;
            Type = type;
        }
    }
}
