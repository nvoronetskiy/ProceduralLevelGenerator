﻿namespace MapGeneration.Interfaces.Core.GeneratorPlanners
{
	// TODO: chage this class or move it elsewhere
	/// <summary>
	/// Interface describing a context of SAGenerator
	/// </summary>
	public interface IGeneratorContext
	{
		int IterationsCount { get; }
	}
}