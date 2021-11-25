import csv
import pandas as pd

ProgrammingLanguage = { "Year":  [1990,
1990,
1990,
1990,
1990,
1990,
1990,
1991,
1991,
1991,
1991,
1991,
1992,
1992,
1992,
1993,
1993,
1993,
1993,
1993,
1993,
1993,
1993,
1993,
1993,
1993,
1994,
1994,
1994,
1994,
1994,
1995,
1995,
1995,
1995,
1995,
1995,
1995,
1995,
1995,
1995,
1996,
1996,
1996,
1996,
1996,
1996,
1997,
1997,
1997,
1997,
1997,
1997,
1997,
1997,
1997,
1998,
1998,
1998,
1998,
1998,
1998,
1998,
1998,
1998,
1999,
1999,
1999,
2000,
2000,
2000,
2001,
2001,
2001,
2001,
2001,
2001,
2001,
2002,
2002,
2002,
2003,
2003,
2003,
2003,
2003,
2003,
2004,
2004,
2004,
2004,
2004,
2005,
2005,
2005,
2005,
2005,
2006,
2006,
2006,
2006,
2006,
2007,
2007,
2007,
2007,
2007,
2007,
2007,
2008,
2008,
2008,
2009,
2009,
2009,
2009,
2009,
2009,
2009], 
                        "Name": ["AMOS BASIC",
"AMPL",
"Object Oberon",
"J",
"Haskell",
"EuLisp",
"Z Shell(zsh)",
"GNU E",
"Oberon-2",
"Oz",
"Q",
"Visual Basic",
"Borland Pascal",
"Dylan",
"S-Lang",
"Self(implementation)",
"Amiga E",
"Brainf*ck",
"LiveCode Transcript",
"AppleScript",
"K",
"Lua",
"R",
"ZPL",
"NewtonScript",
"Euphoria",
"Claire",
"ANSI Common Lisp",
"RAPID",
"Pike",
"ANS Forth",
"Ada 95",
"Borland Delphi",
"ColdFusion (CFML)",
"Java",
"LiveScript",
"Mercury",
"PHP",
"Ruby",
"JavaScript",
"Racket",
"Curl",
"Lasso",
"Perl Data Language(PDL)",
"VBScript",
"OCaml",
"NetRexx",
"Component Pascal",
"E",
"Pico",
"Squeak",
"ECMAScript",
"F-Script",
"ISLISP",
"Tea",
"REBOL",
"Logtalk",
"ActionScript",
"Standard C++",
"M2001",
"Pikt",
"PureBasic",
"UnrealScript",
"XSLT(+XPath)",
"Xojo(REALbasic at the time)",
"C99",
"Game Maker Language(GML)",
"Harbour",
"Join Java",
"DarkBasic",
"C#",
"Joy",
"AspectJ",
"D",
"Processing",
"Visual Basic .NET",
"GDScript(GDS)",
"Shakespeare Programming Language",
"Io",
"Gosu",
"Scratch",
"Nemerle",
"Factor",
"Scala",
"C++03",
"Squirrel",
"Boo",
"Subtext",
"Alma-0",
"FreeBASIC",
"Groovy",
"Little b",
"Fantom",
"F#",
"Haxe",
"Oxygene",
"Seed7",
"Cobra",
"Windows PowerShell",
"OptimJ",
"Fortress",
"Vala",
"Ada 2005",
"Agda",
"QB64",
"Clojure",
"LOLCODE",
"Oberon-07",
"Swift (parallel scripting language)",
"Nim",
"Genie",
"Pure",
"Chapel",
"Go",
"CoffeeScript",
"Idris",
"Parasail",
"Whiley",
"Dafny"], 
                        "Dev":[
                            ["François Lionet", "Constantin Sotiropoulos"],
["Robert Fourer", "David Gay", "Brian Kernighanat (Bell Laboratories)"],
["H Mössenböck", "J Templ, R Griesemer"],
["Kenneth E. Iverson", "Roger Huiat (Iverson Software)"],
["multiple"],
["multiple"],
["Paul Falstad (Princeton University)"],
["David J. DeWitt, Michael J. Carey"],
["Hanspeter Mössenböck (Wirth)"],
["Gert Smolka and his students"],
["Albert Gräf"],
["Alan Cooper (sold to Microsoft)"],
["multiple"],
["multiple (Apple Computer Inc.)"],
["John E. Davis"],
["Sun Microsystems Inc."],
["Wouter van Oortmerssen"],
["Urban Müller"],
["multiple"],
["Apple Computer Inc."],
["Arthur Whitney"],
["Roberto Ierusalimschy, et al. (Tecgraf, PUC-Rio)"],
["Robert Gentleman, Ross Ihaka"],
["Chamberlain, et al. (University of Washington)"],
["Walter Smith"],
["Robert Craig"],
["Yves Caseau"],
["multiple"],
["ABB Group"],
["Fredrik Hübinette, et al. (Linköping University)"],
["Elizabeth Rather, et al."],
["S. Tucker Taft, et al. (Intermetrics, Inc.)"],
["Anders Hejlsbergat (Borland)"],
["Allaire"],
["James Gosling (Sun Microsystems)"],
["Brendan Eichat (Netscape)"],
["Zoltan Somogyiat (University of Melbourne)"],
["Rasmus Lerdorf"],
["Yukihiro Matsumoto"],
["Brendan Eichat (Netscape)"],
["Matthew Flatt (Rice University)"],
["David Kranz", "Steve Ward", "Chris Terman (MIT)"],
["Blue World Communications Inc."],
["Karl Glazebrook", "Jarle Brinchmann", "Tuomas Lukka", "Christian Soeller"],
["Microsoft"],
["INRIA"],
["Mike Cowlishaw"],
["Oberon microsystems Inc"],
["Mark S. Miller"],
["Free University of Brussels",],
["Alan Kay, et al. (Apple Computer Inc.)",],
["ECMATC39-TG1"],
["Philippe Mougin",],
["ISO Standard ISLISP",],
["Jorge Nunes"],
["Carl Sassenrath (Rebol Technologies)",],
["Paulo Moura (University of Coimbra)",],
["Gary Grossman"],
["ANSI/ISO Standard C++"],
["Ronald E. Prather (Trinity University, Texas)",],
["Robert Osterlund (University of Chicago)",],
["Frederic Laboureur (Fantaisie Software)",],
["Tim Sweeney (Epic Games)",],
["James Clark (W3C)"],
["Andrew Barry (Xojo, Inc.)",],
["C99 ISO/IEC 9899:1999",],
["Mark Overmars"],
["Antonio Linares",],
["G Stewart von Itzstein",],
["The Game Creators"],
["Anders Hejlsberg (Microsoft, ECMA)"],
["Manfred von Thun"],
["Gregor Kiczales (Xerox PARC)",],
["Walter Bright (Digital Mars)"],
["Casey Reas, Benjamin Fry"],
["Microsoft"],
["OKAM Studio"],
["Jon Åslund, Karl Hasselström"],
["Steve Dekorte"],
["Guidewire Software"],
["Mitchel Resnick, John Maloney, Natalie Rusk, Evelyn Eastmond, Tammy Stern, Amon Millner, Jay Silver, Brian Silverman"],
["University of Wrocław"],
["Slava Pestov"],
["Martin Odersky"],
["C++ ISO/IEC 14882:2003"],
["Alberto Demichelis"],
["Rodrigo B. de Oliveira"],
["Jonathan Edwards"],
["Krzysztof Apt (Centrum Wiskunde & Informatica)",],
["Andre Victor"],
["James Strachan"],
["Aneil Mallavarapu (Harvard Medical School, Department of Systems Biology)",],
["Brian Frank, Andy Frank"],
["Don Syme (Microsoft Research)"],
["Nicolas Cannasse"],
["RemObjects Software"],
["Thomas Mertes"],
["ChuckEsterbrook"],
["Microsoft"],
["Ateji"],
["Guy Steele",],
["GNOME"],
["Ada Rapporteur Group"],
["Ulf Norell"],
["Galleon, QB64Team"],
["Rich Hickey"],
["Adam Lindsay"],
["Wirth"],
["University of Chicago (Argonne National Laboratory)"],
["Andreas Rumpf"],
["Jamie McCracken"],
["Albert Gräf"],
["Brad Chamberlain (CrayInc.)"],
["Google"],
["Jeremy Ashkenas"],
["Edwin Brady"],
["S. Tucker Taft (AdaCore)"],
["David J. Pearce"],
["K. Rustan M. Leino"]
]
                    } 

with open('/Users/leonardoemanuele/C#, .NET/create_csv_file/my_csv.tsv', 'wt') as my_csv:
    tsv_writer = csv.writer(my_csv, delimiter='\t')
    tsv_writer.writerow(['Year', 'Name', 'Dev'])
    for key in ProgrammingLanguage.values():
        print(key)
    