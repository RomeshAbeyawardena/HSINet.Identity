using System;
namespace HSINet.Identity.Http;

public interface ILink {
	string? Name { get; }
	string? Value { get; }
}

public class Link : ILink
{
	public string? Name { get; set; }
	public string? Value { get; set; }
}