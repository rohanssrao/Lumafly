﻿using System;
using Scarab.Services;

namespace Scarab.Models;
/// <summary>
/// A record to represent a pack of mods
/// </summary>
[Serializable]
public record Pack(string Name, string Description, InstalledMods InstalledMods)
{
    /// <summary>
    /// A list of the names of the mods in the profile.
    /// </summary>
    public InstalledMods InstalledMods { get; set; } = InstalledMods;
    
    /// <summary>
    /// The name of the pack
    /// </summary>
    public string Name { get; set; } = Name;
    
    /// <summary>
    /// The description of the pack
    /// </summary>
    public string Description { get; set; } = Description;
}