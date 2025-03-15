using System;
using System.Collections.Generic;
using System.Text;
public class RemoteJobOffer : JobOffer
{
    public RemoteJobOffer(string jobTitle, string company, double salary, bool fullyRemote) : base(jobTitle, company, salary)
    {
        FullyRemote = fullyRemote;
    }
    public bool FullyRemote { get; }
    public override string ToString()
    {
        string yesOrNo = FullyRemote ? "yes": "no";
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.Append($"Fully Remote: {yesOrNo}");
        return sb.ToString();
    }
}