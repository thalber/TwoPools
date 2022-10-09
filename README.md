# TwoPools
 A paste-in class snippet for two-way linked item pools.

## Usage
 Drop `TwoPools.cs` into your project as a source file.

## Dependencies
 Requires C#10+. Made for .NET Framework 3.5 game, so should probably work on every framework after that.
 
## Notices
 Adding and removing items is slow (may also allocate a lot, if one of the pools is filled with valuetypes) because the class needs to re-generate links.