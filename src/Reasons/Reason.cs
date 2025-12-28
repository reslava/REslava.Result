using System;
using System.Collections.Generic;
using System.Text;

namespace REsl.Result;

public class Reason : IReason
{
    public string Message { get; private set; }
    public Dictionary<string, object> Metadata { get; }

    protected Reason ()
    {
        Metadata = [];
        Message = string.Empty;
    }
    public Reason (string message) : this ()
    {
        Message = message;
    }
    public IReason WithMessage (string message) { Message = message; return this; }
    public IReason WithMetadata (string key, object value) { Metadata.Add (key, value); return this; }
    public IReason WithMetadata (Dictionary<string, object> metadata)
    {
        foreach (var metadataItem in metadata)
            Metadata.Add (metadataItem.Key, metadataItem.Value);

        return this;
    }
}
