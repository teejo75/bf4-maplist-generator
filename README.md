BF4MapListGenerator
===================

This is a utility to generate RANDOM Battlefield 4 map lists for server
admins. You can generate human readable lists for manual entry into 
admin tools such as procon, or you can generate maplist.txt style lists
to copy and paste directly in to your server's maplist.txt.

NOTE: If you extracted the new version over an older version of the program,
please delete the file BF4MapListGenerator.dat, otherwise you may have
errors when launching it.

Known Issues with current release:
- None

Changelog:
22 January 2016:
 - Add support for Dragon Valley 2015
 - Finally fixed the race condition that would sometimes prevent the output window from showing (hopefully for good)
10 November 2015:
 - Add support for Night Map, and Community Map.
27 May 2015:
 - Add support for Gunmaster & Squad Obliteration (Spring Patch)
14 May 2015:
 - Fixed a bug when trying to generate a map list for maps that don't have a particular game type that was in the selection list.
 - Minor internal change to the way the updater works.
18 November 2014:
 - Update for Final Stand
27 July 2014:
 - Update for Dragon's Teeth
17 April 2014:
 - Fix map selection menu desync when loading settings from disk.
11 April 2014:
 - Update for Naval Strike
19 February 2014:
 - Update for Second Assault
22 January 2014:
 - Add update notifier
13 January 2014:
 - Fix pattern list up/down function
18 December 2013:
 - Cosmetic changes
 - Added button for copy to clipboard on output window.
16 December 2013:
 - Fixed stupid bug caused by a typo.
 - Corrected a hang problem when using a large amount of patterns.
13 December 2013:
 - Initial release, based on BF3MapListGenerator R24

NOTE: THIS IS BETA SOFTWARE.
DISCLAIMER OF WARRANTIES AND LIMITATION OF LIABILITY

The software is supplied "as is" and all use it as your own risk. The software
author / distributor disclaims all warranties of any kind, either express or 
implied, as to the software, including but not limited to, implied warranties
of fitness for a particular purpose, merchantability or non-infringement of 
proprietary rights. Neither this agreement nor any documentation furnished 
under it is intended to express or imply any warranty that the operation of the
software will be uninterrupted, timely, or error-free.

Under no circumstances shall the software author / distributor be liable to any
user for direct, indirect, incidental, consequential, special, or exemplary 
damages, arising from or relating to this agreement, the software, or user's 
use or misuse of the software or any other services provided by the software 
author / distributor. Such limitation of liability shall apply whether the 
damages arise from the use or misuse of the software or any other services 
supplied by the software author / distributor (including such damages incurred 
by third parties), or errors of the software.

How to use it:
==============
This may not be immediately obvious from the interface layout, but I'll
try to keep it simple.

Unselect the maps that you do NOT want to appear in the generated list.
Via the Map Selection menu, you can quickly select which expansion packs
you want to include or exclude from selection.
The generated map list is governed by the pattern list (the right hand 
list). Select the game type pattern that you want to appear in the 
output list (as well as the desired number of rounds).

For example, to generate a typical Conquest 1 round, Rush 2 round map
list, you would simply add a gametype of B2K Conquest, 1 round, and 
Rush, 2 rounds to the pattern.

Ensure the infinite checkbox (∞) is selected (very bottom checkbox 
between the lists with the infinity symbol), and on the menu, click 
Generate->maplist.txt or Generate->Human Readable. A random map list 
will then be generated based on the defined pattern until all maps are 
used.

Note that if you select a game type that only has a few maps (like 
assault), and a rush game type, the assault maps will be continually
repeated until there are no more rush maps left, unless you select the
top checkbox (≠∞). In that case, if there are no more maps left for a 
given game type, they will not be repeated, and only maps from the 
remaining game types will be used.

You can unselect the Infinite checkbox and specify how many times
you want the pattern to repeat instead, from once, to 100 times.

I've tried to avoid having the same two maps of different game types
following one another, but it is difficult to test every single 
scenario.

There is no checking of game type combinations at this time, so it is 
very easy to generate strange map lists. It is not wise, for example,
to mix Squad Rush and Conquest maps as the number of players are
incompatible.

If you're unhappy with the distribution of a generated list, just 
generate a new one, or edit the generated list.