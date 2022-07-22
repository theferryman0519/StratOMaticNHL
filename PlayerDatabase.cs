using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
using UnityEngine.Networking;
using System.Data;
using System.IO;
using System.Net;

public class PlayerDatabase : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	// Player Information
	public static string PlayerUsername;
	public static string PlayerFirstName;
	public static string PlayerComputerWins;
	public static string PlayerComputerLosses;
	public static string PlayerComputerOvertimes;
	public static string PlayerFranchiseWins;
	public static string PlayerFranchiseLosses;
	public static string PlayerFranchiseOvertimes;

	public static string PlayerChosenTeam;
	public static string ComputerChosenTeam;

	public static int CurrentFranchiseSelect;

	// Player Chosen Team
	public static string P1LW1;
	public static string P1LW2;
	public static string P1LW3;
	public static string P1LW4;
	public static string P1C1;
	public static string P1C2;
	public static string P1C3;
	public static string P1C4;
	public static string P1RW1;
	public static string P1RW2;
	public static string P1RW3;
	public static string P1RW4;
	public static string P1LD1;
	public static string P1LD2;
	public static string P1LD3;
	public static string P1RD1;
	public static string P1RD2;
	public static string P1RD3;
	public static string P1G;

	// Computer Chosen Team
	public static string P2LW1;
	public static string P2LW2;
	public static string P2LW3;
	public static string P2LW4;
	public static string P2C1;
	public static string P2C2;
	public static string P2C3;
	public static string P2C4;
	public static string P2RW1;
	public static string P2RW2;
	public static string P2RW3;
	public static string P2RW4;
	public static string P2LD1;
	public static string P2LD2;
	public static string P2LD3;
	public static string P2RD1;
	public static string P2RD2;
	public static string P2RD3;
	public static string P2G;

    // Player Special Teams
    public static string P1PKLW;
    public static string P1PKRW;
    public static string P1PKLD;
    public static string P1PKRD;
    public static string P1PKExW;
    public static string P1PKExD;
    public static string P1PPLW;
    public static string P1PPC;
    public static string P1PPRW;
    public static string P1PPLD;
    public static string P1PPRD;

    // Computer Special Teams
    public static string P2PKLW;
    public static string P2PKRW;
    public static string P2PKLD;
    public static string P2PKRD;
    public static string P2PKExW;
    public static string P2PKExD;
    public static string P2PPLW;
    public static string P2PPC;
    public static string P2PPRW;
    public static string P2PPLD;
    public static string P2PPRD;

	// In Game Information
	public static string GameplayPeriod;
	public static string GameplayPlay;
	public static string GameplayLine;
	public static string GameplayPossession;
	public static string GameplayP1Score;
	public static string GameplayP2Score;
	public static string GameplayP1Shots;
	public static string GameplayP2Shots;
	public static string GameplayP1ShootoutGoals;
	public static string GameplayP2ShootoutGoals;
	public static string GameplayPenaltyOnOff;
	public static string GameplayPenaltyType;
	public static string GameplayPenaltyTeam;
	public static string GameplayPenaltyPlayer;
	public static string GameplayGoalScorer;
	public static string GameplayAssistA;
	public static string GameplayAssistB;

	// In Game Stats
	public static int StatsP1FaceoffsWon;
	public static int StatsP2FaceoffsWon;
	public static int StatsP1Powerplays;
	public static int StatsP2Powerplays;
	public static int StatsP1ShotsPeriod1;
	public static int StatsP1ShotsPeriod2;
	public static int StatsP1ShotsPeriod3;
	public static int StatsP1ShotsPeriod4;
	public static int StatsP2ShotsPeriod1;
	public static int StatsP2ShotsPeriod2;
	public static int StatsP2ShotsPeriod3;
	public static int StatsP2ShotsPeriod4;

	// Team Skaters
	public static string[] SkatersANA = {"Zach AstonReese", "Simon Benoit", "Sam Carrick", "Trevor Carrick", "Maxime Comtois", "Hunter Drew", "Jamie Drysdale", "Cam Fowler", "Derek Grant", "BenoitOlivier Groulx", "Brendan Guhle", "Adam Henrique", "Max Jones", "Ryan Kesler", "Bryce Kindopp", "Jacob Larsson", "Vinni Lettieri", "Isac Lundestrom", "Josh Mahura", "Gerald Mayhew", "Mason McTavish", "Sonny Milano", "Danny ORegan", "Greg Pateryn", "Jacob Perreault", "Brogan Rafferty", "Buddy Robinson", "Kevin Shattenkirk", "Jakob Silfverberg", "Dominik Simon", "Sam Steel", "Ryan Strome", "Andrej Sustr", "Troy Terry", "Brayden Tracey", "Urho Vaakanainen", "Frank Vatrano", "Alexander Volkov", "Trevor Zegras"};
	public static string[] SkatersARI = {"Jay Beagle", "Nick Bjugstad", "Travis Boyd", "Josh Brown", "Michael Carcone", "Jakob Chychrun", "Lawson Crouse", "JeanSebastien Dea", "Cam Dineen", "Loui Eriksson", "Hudson Fasching", "Christian Fischer", "Alex Galchenyuk", "Shayne Gostisbehere", "Barrett Hayton", "Bokondji Imama", "Dmitri Jaskin", "Jan Jenik", "Zack Kassian", "Clayton Keller", "Phil Kessel", "Vladislav Kolyachonok", "Andrew Ladd", "Bryan Little", "Matias Maccelli", "Dysin Mayo", "Jack McBain", "Ben McCartney", "JJ Moser", "Riley Nash", "Patrik Nemeth", "Liam OBrien", "Nick Ritchie", "Antoine Roussel", "Nick Schmaltz", "Victor Soderstrom", "Blake Speers", "Troy Stecher", "Anton Stralman", "Conor Timmins"};
	public static string[] SkatersBOS = {"Jack Ahcan", "Patrice Bergeron", "Anton Blidh", "Brandon Carlo", "Peter Cehlarik", "Connor Clifton", "Charlie Coyle", "Jake DeBrusk", "Steven Fogarty", "Nick Foligno", "Derek Forbort", "Jakob ForsbackaKarlsson", "Trent Frederic", "Jesper Froden", "AJ Greer", "Matt Grzelcyk", "Taylor Hall", "Cameron Hughes", "Tyler Lewington", "Hampus Lindholm", "Brad Marchand", "Charlie McAvoy", "Marc McLaughlin", "John Moore", "Tomas Nosek", "David Pastrnak", "Mike Reilly", "Craig Smith", "Oskar Steen", "Jack Studnicka", "Chris Wagner", "Pavel Zacha", "Jakub Zboril"};
	public static string[] SkatersBUF = {"Rasmus Asplund", "Brandon Biro", "Anders Bjork", "Johnny Boychuk", "Jacob Bryson", "Will Butcher", "Dylan Cozens", "Rasmus Dahlin", "Brandon Davidson", "Cody Eakin", "Casey Fitzgerald", "Zemgus Girgensons", "John Hayden", "Vinnie Hinostroza", "Mark Jankowski", "Henri Jokiharju", "Peyton Krebs", "Ilya Lyubushkin", "Ryan MacInnis", "Sean Malone", "Casey Mittelstadt", "Brett Murray", "Kyle Okposo", "Victor Olofsson", "John Peterka", "Lawrence Pilut", "Owen Power", "Ethan Prow", "Jack Quinn", "Arttu Ruotsalainen", "Mattias Samuelsson", "Jeff Skinner", "Tage Thompson", "Alex Tuch"};
	public static string[] SkatersCAL = {"Rasmus Andersson", "Mikael Backlund", "Blake Coleman", "Dillon Dube", "Walker Duehr", "Byron Froese", "Glenn Gawdin", "Dennis Gilbert", "Kevin Gravel", "Noah Hanifin", "Oliver Kylington", "Trevor Lewis", "Elias Lindholm", "Milan Lucic", "Connor Mackey", "Andrew Mangiapane", "Nicolas Meloche", "Sean Monahan", "Matthew Phillips", "Brett Ritchie", "Kevin Rooney", "Adam Ruzicka", "Michael Stone", "Christopher Tanev", "Matthew Tkachuk", "Tyler Toffoli", "Juuso Valimaki", "Andy Welinski", "Alexander Yelesin", "Nikita Zadorov"};
	public static string[] SkatersCAR = {"Sebastian Aho", "Ethan Bear", "Brent Burns", "Jalen Chatfield", "Dylan Coghlan", "Jack Drury", "Jesper Fast", "Jake Gardiner", "Gregory Hofmann", "Josh Jacobs", "Seth Jarvis", "Ondrej Kase", "Joey Keane", "Jesperi Kotkaniemi", "Maxime Lajoie", "Jordan Martinook", "Martin Necas", "Stefan Noesen", "Max Pacioretty", "Lane Pederson", "Brett Pesce", "Tarmo Reunanen", "Brady Skjei", "Jaccob Slavin", "CJ Smith", "Jordan Staal", "Derek Stepan", "Andrei Svechnikov", "Teuvo Teravainen"};
	public static string[] SkatersCHI = {"Andreas Athanasiou", "Nicolas Beaudin", "Colin Blackwell", "Brett Connolly", "Calvin DeHaan", "Max Domi", "MacKenzie Entwistle", "Kurtis Gabriel", "Jakub Galvas", "Mike Hardman", "Reese Johnson", "Tyler Johnson", "Caleb Jones", "Seth Jones", "Patrick Kane", "Boris Katchouk", "Jujhar Khaira", "Philipp Kurashev", "Sam Lafferty", "Jake McCabe", "Ian Mitchell", "Connor Murphy", "Isaak Phillips", "Alec Regula", "Dylan Sikura", "Riley Stillman", "Jonathan Toews", "Alex Vlasic"};
	public static string[] SkatersCOL = {"Bowen Byram", "Andrew Cogliano", "JT Compher", "Samuel Girard", "Jordan Gross", "Darren Helm", "Brad Hunt", "Erik Johnson", "Jack Johnson", "Nazem Kadri", "Vladislav Kamenev", "Martin Kaut", "Gabriel Landeskog", "Artturi Lehkonen", "Kurtis MacDermid", "Jacob MacDonald", "Nathan MacKinnon", "Cale Makar", "Mikhail Maltsev", "Josh Manson", "Stefan Matteau", "Jayson Megna", "Ben Meyers", "Keaton Middleton", "Ryan Murray", "Alex Newhook", "Valeri Nichushkin", "Logan OConnor", "Sampo Ranta", "Mikko Rantanen", "Kiefer Sherwood", "Devon Toews"};
	public static string[] SkatersCBJ = {"Gavin Bayreuther", "Jake Bean", "Emil Bemstrom", "Oliver Bjorkstrand", "Nick Blankenburg", "Adam Boqvist", "Yegor Chinakhov", "Jacob Christiansen", "Justin Danforth", "Josh Dunne", "Trey FixWolansky", "Liam Foudy", "Johnny Gaudreau", "Brendan Gaunce", "Vladislav Gavrikov", "Nathan Gerbe", "Erik Gudbranson", "Scott Harrington", "Boone Jenner", "Dean Kukan", "Sean Kuraly", "Patrik Laine", "Carson Meyer", "Gustav Nyquist", "Mathieu Olivier", "Andrew Peeke", "Zac Rinaldo", "Eric Robinson", "Jack Roslovic", "Cole Sillinger", "Kevin Stenlund", "Alexandre Texier", "Calvin Thurkauf", "Jakub Voracek", "Zach Werenski"};
	public static string[] SkatersDAL = {"Riley Barber", "Jamie Benn", "Nick Caamano", "Blake Comeau", "Riley Damiani", "Ty Dellandrea", "Radek Faksa", "Rhett Gardner", "Luke Glendening", "Denis Gurianov", "Jani Hakanpaa", "Joel Hanley", "Thomas Harley", "Miro Heiskanen", "Roope Hintz", "Fredrik Karlstrom", "Tanner Kero", "Joel Kiviranta", "John Klingberg", "Joel LEsperance", "Esa Lindell", "Mason Marchment", "Colin Miller", "Joe Pavelski", "Jacob Peterson", "Alex Petrovic", "Michael Raffl", "Jason Robertson", "Tyler Seguin", "Marian Studenic", "Ryan Suter", "Riley Tufte"};
	public static string[] SkatersDET = {"Tyler Bertuzzi", "Ben Chiarot", "Andrew Copp", "Kyle Criscuolo", "Danny DeKeyser", "Turner Elson", "Adam Erne", "Robby Fabbri", "Sam Gagner", "Taro Hirose", "Filip Hronek", "Olli Juolevi", "Dominik Kubalik", "Dylan Larkin", "Brian Lashoff", "Gustav Lindstrom", "Olli Maatta", "Ryan Murphy", "Jordan Oesterle", "Chase Pearson", "David Perron", "Mark Pysyk", "Michael Rasmussen", "Lucas Raymond", "Dan Renouf", "Carter Rowney", "Moritz Seider", "Givani Smith", "Oskar Sundqvist", "Pius Suter", "Joe Veleno", "Jakub Vrana", "Jake Walman", "Filip Zadina"};
	public static string[] SkatersEDM = {"Tyson Barrie", "Tyler Benson", "Evan Bouchard", "Derick Brassard", "Philip Broberg", "Cody Ceci", "Leon Draisaitl", "Warren Foegele", "Seth Griffith", "Zach Hyman", "Mattias Janmark", "Evander Kane", "Oscar Klefbom", "Slater Koekkoek", "Brett Kulak", "Brad Malone", "Cooper Marody", "Connor McDavid", "Greg McKegg", "Ryan McLeod", "Markus Niemelainen", "Ryan NugentHopkins", "Darnell Nurse", "Brendan Perlini", "Jesse Puljujarvi", "Kris Russell", "Derek Ryan", "Dmitri Samorukov", "Colton Sceviour", "Devin Shore", "Kyle Turris", "Kailer Yamamoto"};
	public static string[] SkatersFLA = {"Rudolfs Balcers", "Aleksander Barkov", "Sam Bennett", "Connor Bunnaman", "Lucas Carlsson", "Nick Cousins", "Zac Dalpe", "Michael DelZotto", "Grigory Denisenko", "Anthony Duclair", "Aaron Ekblad", "Gustav Forsling", "Radko Gudas", "Robert Hagg", "Aleksi Heponiemi", "Patric Hornqvist", "Jonathan Huberdeau", "Matt Kiersted", "Yegor Korshkov", "Petteri Lindbohm", "Ryan Lomberg", "Anton Lundell", "Eetu Luostarinen", "Maxim Mamin", "Brandon Montour", "Chase Priskie", "Sam Reinhart", "German Rubtsov", "Aleksi Saarela", "Cole Schwindt", "Marc Staal", "Joe Thornton", "Chris Tierney", "Carter Verhaeghe", "MacKenzie Weegar", "Colin White"};
	public static string[] SkatersLAK = {"Frederic Allard", "Michael Anderson", "Jaret AndersonDolan", "Lias Andersson", "Viktor Arvidsson", "Tobias Bjornfot", "Quinton Byfield", "Phillip Danault", "Drew Doughty", "Sean Durzi", "Alexander Edler", "Samuel Fagemo", "Kevin Fiala", "Martin Frk", "Carl Grundstrom", "Alex Iafallo", "Arthur Kaliyev", "Adrian Kempe", "Anze Kopitar", "Rasmus Kupari", "Brendan Lemieux", "Blake Lizotte", "Trevor Moore", "Jacob Moverare", "Nelson Nogier", "Matt Roy", "Jordan Spence", "Austin Strand", "Vladimir Tkachyov", "Alex Turcotte", "TJ Tynan", "Gabriel Vilardi", "Austin Wagner", "Sean Walker"};
	public static string[] SkatersMIN = {"Calen Addison", "Brandon Baddock", "Adam Beckman", "Jonas Brodin", "Mitchell Chaffee", "Joseph Cramarossa", "Kevin Czuczman", "Connor Dewar", "Brandon Duhaime", "Matt Dumba", "Joel ErikssonEk", "Marcus Foligno", "Frederick Gaudreau", "Alex Goligoski", "Jordan Greenway", "Ryan Hartman", "Joe Hicketts", "Tyson Jost", "Kirill Kaprizov", "Dmitri Kulikov", "Dakota Mermis", "Jon Merrill", "Jacob Middleton", "Kyle Rau", "Marco Rossi", "Jared Spurgeon", "Dominic Turgeon", "Mats Zuccarello"};
	public static string[] SkatersMON = {"Josh Anderson", "Joel Armia", "Justin Barron", "Louis Belpedio", "Alex Belzile", "Madison Bowey", "Paul Byron", "Cole Caufield", "Kale Clague", "Kirby Dach", "Evgeny Dadonov", "Laurent Dauphin", "Jonathan Drouin", "Christian Dvorak", "Joel Edmundson", "Jake Evans", "Brendan Gallagher", "Jordan Harris", "Rafael HarveyPinard", "Cameron Hillis", "Mike Hoffman", "William Lagesson", "Otto Leskinen", "Mike Matheson", "Sami Niku", "Mattias Norlinder", "Xavier Ouellet", "Cedric Paquette", "Mathieu Perreault", "Michael Pezzetta", "Rem Pitlick", "Tyler Pitlick", "Anthony Richard", "David Savard", "Corey Schueneman", "Mitchell Stephens", "Nick Suzuki", "Lukas Vejdemo", "Chris Wideman", "Jesse Ylonen"};
	public static string[] SkatersNAS = {"Alex Biega", "Mark Borowiecki", "Alexandre Carrier", "Jeremy Davies", "Matt Duchene", "Mattias Ekholm", "Dante Fabbro", "David Farrance", "Filip Forsberg", "Cody Glass", "Mikael Granlund", "Rocco Grimaldi", "Ben Harpur", "Tanner Jeannot", "Ryan Johansen", "Roman Josi", "Jeremy Lauzon", "John Leonard", "Matt Luff", "Michael McCarron", "Ryan McDonagh", "Nino Niederreiter", "Zach Sanford", "Kole Sherwood", "Colton Sissons", "Cole Smith", "Eeli Tolvanen", "Philip Tomasino", "Yakov Trenin"};
	public static string[] SkatersNJD = {"Kevin Bahl", "Nathan Bastian", "Jesper Boqvist", "Jesper Bratt", "Chase DeLeo", "Nolan Foote", "Joe Gambardella", "Frederik Gauthier", "Mason Geertsen", "Ryan Graves", "Dougie Hamilton", "Erik Haula", "Nico Hischier", "Alexander Holtz", "Jack Hughes", "Andreas Johnson", "Janne Kuokkanen", "John Marino", "Michael McLeod", "Dawson Mercer", "Nikita Okhotyuk", "Ondrej Palat", "Damon Severson", "Yegor Sharangovich", "Jonas Siegenthaler", "Brendan Smith", "PK Subban", "Tomas Tatar", "Tyce Thompson", "Jimmy Vesey", "Reilly Walsh", "Colton White", "Miles Wood", "Fabian Zetterlund"};
	public static string[] SkatersNYI = {"SJ Aho", "Andy Andreoff", "Josh Bailey", "Cole Bardreau", "Mathew Barzal", "Anthony Beauvillier", "Kieffer Bellows", "Zdeno Chara", "Casey Cizikas", "Cal Clutterbuck", "Austin Czarnik", "Michael DalColle", "Noah Dobson", "Andy Greene", "Thomas Hickey", "Ross Johnston", "Otto Koivula", "Paul LaDue", "Anders Lee", "Matt Martin", "Scott Mayfield", "Brock Nelson", "JeanGabriel Pageau", "Kyle Palmieri", "Richard Panik", "Zach Parise", "Adam Pelech", "Ryan Pulock", "Alexander Romanov", "Robin Salo", "Oliver Wahlstrom"};
	public static string[] SkatersNYR = {"Sammy Blais", "Jonny Brodzinski", "Ryan Carpenter", "Filip Chytil", "Adam Fox", "Julien Gauthier", "Tim Gettinger", "Barclay Goodrow", "Anthony Greco", "Libor Hajek", "Dryden Hunt", "Zac Jones", "Kaapo Kakko", "Chris Kreider", "Alexis Lafreniere", "Maxim Letunov", "Ryan Lindgren", "Nils Lundkvist", "Nick Merkley", "KAndre Miller", "Tyler Motte", "Artemi Panarin", "Ryan Reaves", "Justin Richards", "Braden Schneider", "Jarred Tinordi", "Vincent Trocheck", "Jacob Trouba", "Mika Zibanejad"};
	public static string[] SkatersOTT = {"Vitaly Abramov", "Olle Alsing", "Drake Batherson", "Jacob BernardDocker", "Clark Bishop", "Erik Brannstrom", "Thomas Chabot", "Alex DeBrincat", "Tyler Ennis", "Alex Formenton", "Dylan Gambrell", "Claude Giroux", "Travis Hamonic", "Dillon Heatherington", "Nick Holden", "Mathieu Joseph", "Mark Kastelic", "Parker Kelly", "Viktor Lodin", "Josh Norris", "Shane Pinto", "Cole Reinhardt", "Kristians Rubins", "Scott Sabourin", "Zach Senyshyn", "Logan Shaw", "Yegor Sokolov", "Tim Stutzle", "Lassi Thomson", "Brady Tkachuk", "Austin Watson", "Nikita Zaitsev", "Artyom Zub"};
	public static string[] SkatersPHI = {"Wade Allison", "Cam Atkinson", "Ronnie Attard", "Justin Braun", "Bobby Brink", "Patrick Brown", "Jackson Cates", "Adam Clendening", "Kevin Connauton", "Sean Couturier", "Tony DeAngelo", "Nick Deslauriers", "Ryan Ellis", "Joel Farabee", "Morgan Frost", "Kevin Hayes", "Hayden Hodgson", "Linus Hogberg", "David Kase", "Travis Konecny", "Tanner Laczynski", "Scott Laughton", "Zack MacEwen", "Brennan Menell", "Samuel Morin", "Ivan Provorov", "Isaac Ratcliffe", "Rasmus Ristolainen", "Linus Sandin", "Travis Sanheim", "Nick Seeler", "Maxim Sushko", "Nate Thompson", "Owen Tippett", "James VanRiemsdyk", "Mikhail Vorobyov", "Maxwell Willman", "Keith Yandle", "Cam York", "Yegor Zamula"};
	public static string[] SkatersPIT = {"Anthony Angello", "Josh Archibald", "Nathan Beaulieu", "Kasper Bjorkqvist", "Teddy Blueger", "Brian Boyle", "Drake Caggiula", "Jeff Carter", "Michael Chaput", "Sidney Crosby", "Brian Dumoulin", "Taylor Fedun", "Mark Friedman", "Jake Guentzel", "Filip Hallander", "Danton Heinen", "PierreOlivier Joseph", "Kasperi Kapanen", "Kris Letang", "Evgeni Malkin", "Brock McGinn", "Alexander Nylander", "Drew OConnor", "Jeff Petry", "Marcus Pettersson", "Ryan Poehling", "Valtteri Puustinen", "Rickard Rakell", "Juuso Riikola", "Evan Rodrigues", "Chad Ruhwedel", "Bryan Rust", "Jan Rutta", "Ty Smith", "Radim Zohorna", "Jason Zucker"};
	public static string[] SkatersSTL = {"Noel Acciari", "Ivan Barbashev", "Robert Bortuzzo", "Tyler Bozak", "Logan Brown", "Pavel Buchnevich", "Justin Faulk", "Klim Kostin", "Torey Krug", "Jordan Kyrou", "Nick Leddy", "Josh Leivo", "MacKenzie MacEachern", "Niko Mikkola", "James Neal", "Jake Neighbours", "Ryan OReilly", "Colton Parayko", "Matthew Peca", "Scott Perunovich", "Calle Rosen", "Brandon Saad", "Steve Santini", "Marco Scandella", "Brayden Schenn", "Vladimir Tarasenko", "Robert Thomas", "Alexei Toropchenko", "Nathan Walker", "Luke Witkowski"};
	public static string[] SkatersSJS = {"Andrew Agozzino", "Alexander Barabanov", "Matt Benning", "Anthony Bitetto", "Joachim Blichfeld", "Nick Bonino", "Thomas Bordeleau", "Alexander Chmelevski", "Logan Couture", "Jonathan Dahlen", "Ryan Dzingel", "William Eklund", "Mario Ferraro", "Jonah Gadjovich", "Noah Gregor", "Jayden Halbgewachs", "Santeri Hatakka", "Tomas Hertl", "Erik Karlsson", "Artemi Knyazev", "Nikolai Knyzhov", "Luke Kunin", "Kevin Labanc", "Oskar Lindblom", "Steven Lorentz", "Jaycob Megna", "Timo Meier", "Matt Nieto", "Markus Nutivaara", "Brinson Pasichnuk", "Adam Raska", "Scott Reedy", "Radim Simek", "Nico Sturm", "CJ Suess", "Jeffrey TruchonViel", "MarcEdouard Vlasic", "Jasper Weatherby"};
	public static string[] SkatersSEA = {"Matthew Beniers", "Will Borgen", "Andre Burakovsky", "Connor Carrick", "Dennis Cholowski", "Ryan Donato", "Joonas Donskoi", "Vince Dunn", "Jordan Eberle", "Cale Fleury", "Morgan Geekie", "Yanni Gourde", "Karson Kuhlman", "Adam Larsson", "Kole Lind", "Jared McCann", "Max McCormick", "Jamie Oleksiak", "Gustav Olofsson", "Andrew Poturalski", "Derrick Pouliot", "Victor Rask", "Jaden Schwartz", "Riley Sheahan", "Carson Soucy", "Daniel Sprong", "Brandon Tanev", "Alexander True ", "Carsen Twarynski", "Alexander Wennberg"};
	public static string[] SkatersTBL = {"Alex BarreBoulet", "PierreEdouard Bellemare", "Zach Bogosian", "Erik Cernak", "Anthony Cirelli", "Fredrik Claesson", "Ian Cole", "Ross Colton", "Sean Day", "Gabriel Dumont", "Remi Elie", "Haydn Fleury", "Cal Foote", "Gabriel Fortier", "Brandon Hagel", "Victor Hedman", "Charles Hudon", "Alex Killorn", "Nikita Kucherov", "Pat Maroon", "Philippe Myers", "Vladislav Namestnikov", "Nick Paul", "Corey Perry", "Brayden Point", "Darren Raddysh", "Brent Seabrook", "Mikhail Sergachev", "Gemel Smith", "Steven Stamkos", "Daniel Walcott"};
	public static string[] SkatersTOR = {"Nick Abruzzese", "Joey Anderson", "Nicolas AubeKubel", "Jordie Benn", "TJ Brodie", "Michael Bunting", "Kyle Clifford", "Carl Dahlstrom", "Pierre Engvall", "Adam Gaudette", "Mark Giordano", "Justin Holl", "Calle Jarnkrok", "David Kampf", "Alexander Kerfoot", "Timothy Liljegren", "Denis Malgin", "Mitchell Marner", "Auston Matthews", "Victor Mete", "Jake Muzzin", "William Nylander", "Morgan Rielly", "Nick Robertson", "Rasmus Sandin", "Kirill Semyonov", "Brett Seney", "Wayne Simmonds", "Jason Spezza", "Alexander Steeves", "John Tavares"};
	public static string[] SkatersVAN = {"Justin Bailey", "Brock Boeser", "Guillaume Brisebois", "Kyle Burroughs", "Alex Chiasson", "Travis Dermott", "Jason Dickinson", "Phil DiGiuseppe", "Justin Dowling", "Sheldon Dries", "Oliver EkmanLarsson", "Michael Ferland", "Conor Garland", "Matthew Highmore", "Nils Hoglander", "Bo Horvat", "Quinn Hughes", "Dakota Joshua", "Noah Juulsen", "Wyatt Kalynuk", "Brady Keeper", "Juho Lammikko", "Curtis Lazar", "Will Lockwood", "Ilya Mikheyev", "JT Miller", "Tyler Myers", "Tanner Pearson", "Nic Petan", "Elias Pettersson", "Vasily Podkolzin", "Tucker Poolman", "Jack Rathbone", "Sheldon Rempal", "Brad Richardson", "Luke Schenn", "Brandon Sutter", "Christian Wolanin"};
	public static string[] SkatersVGK = {"Mike Amadio", "Sven Bartschi", "Jake Bischoff", "William Carrier", "Paul Cotter", "Pavel Dorofeyev", "Jack Eichel", "Nicolas Hague", "Brett Howden", "Ben Hutton", "Benjamin Jones", "William Karlsson", "Keegan Kolesar", "Kaedan Korczak", "Jake Leschyshyn", "Jonathan Marchessault", "Alec Martinez", "Brayden McNabb", "Daniil Miromanov", "Brayden Pachal", "Nolan Patrick", "Alex Pietrangelo", "Gage Quinney", "Jonas Rondbjerg", "Nicolas Roy", "Reilly Smith", "Chandler Stephenson", "Mark Stone", "Shea Theodore", "Shea Weber", "Zach Whitecloud"};
	public static string[] SkatersWAS = {"Alexander Alexeyev", "Nicklas Backstrom", "Henrik Borgstrom", "Connor Brown", "John Carlson", "Gabriel Carlsson", "Nic Dowd", "Lars Eller", "Martin Fehervary", "Erik Gustafsson", "Carl Hagelin", "Garnet Hathaway", "Matt Irwin", "Nick Jensen", "Lucas Johansen", "Marcus Johansson", "Axel JonssonFjallby", "Michal Kempny", "Evgeny Kuznetsov", "Hendrix Lapierre", "Johan Larsson", "Brett Leason", "Beck Malenstyn", "Anthony Mantha", "Dylan McIlrath", "Connor McMichael", "Dmitry Orlov", "TJ Oshie", "Alexander Ovechkin", "Garrett Pilon", "Alexei Protas", "Justin Schultz", "Michael Sgarbossa", "Conor Sheary", "Joseph Snively", "Dylan Strome", "Trevor VanRiemsdyk", "Mike Vecchione", "Tom Wilson"};
	public static string[] SkatersWPG = {"Mason Appleton", "Morgan Barron", "Adam Brooks", "Kyle Capobianco", "Declan Chisholm", "Kyle Connor", "Dylan DeMelo", "Brenden Dillon", "PierreLuc Dubois", "Nikolaj Ehlers", "Michael Eyssimont", "David Gustafsson", "Jansen Harkins", "Ville Heinola", "Luke Johnson", "Johnathan Kovacevic", "Adam Lowry", "Jeff Malott", "Josh Morrissey", "Cole Perfetti", "Neal Pionk", "Austin Poganski", "Kristian Reichel", "Dylan Samberg", "Mark Scheifele", "Nate Schmidt", "Logan Stanley", "Paul Stastny", "Evgeny Svechnikov", "Dominic Toninato", "Kristian Vesalainen", "Blake Wheeler"};

	// Team Goalies
	public static string[] GoaliesANA = {"Lukas Dostal", "John Gibson", "Thomas Hodges", "Anthony Stolarz"};
	public static string[] GoaliesARI = {"Josef Korenar", "Ivan Prosvetov", "Harri Sateri", "Karel Vejmelka"};
	public static string[] GoaliesBOS = {"Troy Grosenick", "Jeremy Swayman", "Linus Ullmark"};
	public static string[] GoaliesBUF = {"Craig Anderson", "Eric Comrie", "Michael Houser", "UkkoPekka Luukkonen", "Malcolm Subban", "Dustin Tokarski"};
	public static string[] GoaliesCAL = {"Jacob Markstrom", "Daniel Vladar", "Adam Werner"};
	public static string[] GoaliesCAR = {"Frederik Andersen", "Pyotr Kochetkov", "Jack LaFontaine", "Alex Lyon", "Antti Raanta"};
	public static string[] GoaliesCHI = {"Collin Delia", "Kevin Lankinen", "Petr Mrazek", "Arvid Soderblom", "Alex Stalock"};
	public static string[] GoaliesCOL = {"Justus Annunen", "Pavel Francouz", "Alexandar Georgiev", "Hunter Miska"};
	public static string[] GoaliesCBJ = {"JeanFrancois Berube", "Joonas Korpisalo", "Elvis Merzlikins", "Daniil Tarasov"};
	public static string[] GoaliesDAL = {"Landon Bow", "Braden Holtby", "Anton Khudobin", "Jake Oettinger", "Scott Wedgewood"};
	public static string[] GoaliesDET = {"Kaden Fulcher", "Magnus Hellberg", "Ville Husso", "Alex Nedeljkovic"};
	public static string[] GoaliesEDM = {"Jack Campbell", "Mikko Koskinen", "Calvin Pickard", "Stuart Skinner", "Mike Smith"};
	public static string[] GoaliesFLA = {"Sergei Bobrovsky", "Christopher Gibson", "Jonas Johansson", "Spencer Knight"};
	public static string[] GoaliesLAK = {"Pheonix Copley", "Cal Petersen", "Jonathan Quick", "Garret Sparks"};
	public static string[] GoaliesMIN = {"MarcAndre Fleury", "Filip Gustavsson"};
	public static string[] GoaliesMON = {"Jake Allen", "Andrew Hammond", "Michael McNiven", "Samuel Montembeault", "Carey Price", "Cayden Primeau"};
	public static string[] GoaliesNAS = {"Connor Ingram", "Juuse Saros"};
	public static string[] GoaliesNJD = {"Jonathan Bernier", "Mackenzie Blackwood", "Nico Daws", "Akira Schmid", "Gilles Senn", "Vitek Vanecek"};
	public static string[] GoaliesNYI = {"Cory Schneider", "Ilya Sorokin", "Semyon Varlamov"};
	public static string[] GoaliesNYR = {"Louis Domingue", "Jaroslav Halak", "Adam Huska", "Keith Kinkaid", "Igor Shesterkin"};
	public static string[] GoaliesOTT = {"Anton Forsberg", "Mads Sogaard", "Cam Talbot"};
	public static string[] GoaliesPHI = {"Carter Hart", "Felix Sandstrom"};
	public static string[] GoaliesPIT = {"Casey DeSmith", "Tristan Jarry"};
	public static string[] GoaliesSTL = {"Jordan Binnington", "Jon Gillies", "Thomas Greiss", "Joel Hofer"};
	public static string[] GoaliesSJS = {"Aaron Dell", "Adin Hill", "Kaapo Kahkonen", "James Reimer", "Zachary Sawchenko"};
	public static string[] GoaliesSEA = {"Antoine Bibeau", "Joey Daccord", "Chris Driedger", "Philipp Grubauer", "Martin Jones"};
	public static string[] GoaliesTBL = {"Hugo Alnefelt", "Brian Elliott", "Maxime Lagace", "Alexei Melnichuk", "Andrei Vasilevskiy"};
	public static string[] GoaliesTOR = {"Michael Hutchinson", "Carter Hutton", "Erik Kallgren", "Matt Murray", "Ilya Samsonov", "Joseph Woll"};
	public static string[] GoaliesVAN = {"Thatcher Demko", "Michael DiPietro", "Spencer Martin"};
	public static string[] GoaliesVGK = {"Laurent Brossoit", "Robin Lehner", "Logan Thompson"};
	public static string[] GoaliesWAS = {"Zachary Fucale", "Darcy Kuemper", "Charlie Lindgren"};
	public static string[] GoaliesWPG = {"Connor Hellebuyck", "David Rittich"};

	// Franchise Team Skaters
	public static string[] FrSkatersANA = {"Francois Beauchemin", "Andrew Cogliano", "Cam Fowler", "Ryan Getzlaf", "Adam Henrique", "Paul Kariya", "Chris Kunitz", "Hampus Lindholm", "Josh Manson", "Andy McDonald", "Rob Niedermayer", "Scott Niedermayer", "Fredrik Olausson", "Corey Perry", "Chris Pronger", "Rickard Rakell", "Steve Rucchin", "Bobby Ryan", "Joe Sacco", "Teemu Selanne", "Jakob Silfverberg", "Petr Sykora", "Oleg Tverdovsky", "Sami Vatanen", "Lubomir Visnovsky"};
	public static string[] FrSkatersATL = {"Nikolai Antropov", "Colby Armstrong", "Donald Audette", "Zach Bogosian", "Andrew Brunette", "Dustin Byfuglien", "Greg DeVries", "Tobias Enstrom", "Ray Ferraro", "Ron Hainsey", "Niclas Havelid", "Dany Heatley", "Marian Hossa", "Frantisek Kaberle", "Ilya Kovalchuk", "Vyacheslav Kozlov", "Bryan Little", "Shawn McEachern", "Scott Mellanby", "Marc Savard", "Patrik Stefan", "Andy Sutton", "Daniel Tjarnqvist", "Yannick Tremblay", "Todd White"};
	public static string[] FrSkatersBOS = {"Patrice Bergeron", "Raymond Bourque", "Johnny Bucyk", "Wayne Cashman", "Zdeno Chara", "Dit Clapper", "Woody Dumart", "Phil Esposito", "Ken Hodge", "David Krejci", "Torey Krug", "Brad Marchand", "Don Marcotte", "Peter McNab", "Rick Middleton", "Cam Neely", "Mike OConnell", "Terry OReilly", "Bobby Orr", "Brad Park", "Sergei Samsonov", "Eddie Shore", "Dallas Smith", "Fred Stanfield", "Glen Wesley"};
	public static string[] FrSkatersBUF = {"Dave Andreychuk", "Doug Bodger", "Mike Foligno", "Danny Gare", "Bill Hajt", "Jochen Hecht", "Phil Housley", "Jerry Korab", "Pat LaFontaine", "Don Luce", "Rick Martin", "Alexander Mogilny", "Gilbert Perreault", "Jason Pominville", "Craig Ramsay", "Mike Ramsey", "Rasmus Ristolainen", "Rene Robert", "Derek Roy", "Lindy Ruff", "Miroslav Satan", "Jim Schoenfeld", "John VanBoxmeer", "Thomas Vanek", "Alexei Zhitnik"};
	public static string[] FrSkatersCAL = {"Mikael Backlund", "TJ Brodie", "Theo Fleury", "Johnny Gaudreau", "Mark Giordano", "Phil Housley", "Jarome Iginla", "Hakan Loob", "Al MacInnis", "Jamie Macoun", "Lanny McDonald", "Sean Monahan", "Derek Morris", "Joe Mullen", "Joe Nieuwendyk", "Kent Nilsson", "Joel Otto", "Jim Peplinski", "Dion Phaneuf", "Robyn Regehr", "Paul Reinhart", "Gary Roberts", "Gary Suter", "Alex Tanguay", "Matthew Tkachuk"};
	public static string[] FrSkatersCAR = {"Sebastian Aho", "Rod BrindAmour", "Erik Cole", "Joe Corvo", "Justin Faulk", "Ron Francis", "Tim Gleason", "Dougie Hamilton", "Bret Hedican", "Sean Hill", "Sami Kapanen", "Chad Larose", "Brock McGinn", "Jeff ONeill", "Brett Pesce", "Joni Pitkanen", "Tuomo Ruutu", "Jeff Skinner", "Jaccob Slavin", "Eric Staal", "Andrei Svechnikov", "Jiri Tlusty", "Glen Wesley", "Ray Whitney", "Justin Williams"};
	public static string[] FrSkatersCHI = {"Tony Amonte", "Doug Bentley", "Keith Brown", "Chris Chelios", "Eric Daze", "Bobby Hull", "Dennis Hull", "Patrick Kane", "Duncan Keith", "Steve Larmer", "John Marks", "Pit Martin", "Stan Mikita", "Bill Mosienko", "Bob Murray", "Eric Nesterenko", "Pierre Pilote", "Jeremy Roenick", "Phil Russell", "Denis Savard", "Brent Seabrook", "Patrick Sharp", "Pat Stapleton", "Jonathan Toews", "Doug Wilson"};
	public static string[] FrSkatersCOL = {"Tyson Barrie", "Rob Blake", "Andrew Brunette", "Brett Clark", "Adam Deadmarsh", "Matt Duchene", "Adam Foote", "Peter Forsberg", "Samuel Girard", "Milan Hejduk", "Erik Johnson", "David Jones", "Valeri Kamensky", "Gabriel Landeskog", "Claude Lemieux", "JohnMichael Liles", "Nathan MacKinnon", "Cale Makar", "Sandis Ozolinsh", "Joe Sakic", "Martin Skoula", "Paul Stastny", "Marek Svatos", "Alex Tanguay", "Wojtek Wolski"};
	public static string[] FrSkatersCBJ = {"Cam Atkinson", "Oliver Bjorkstrand", "Matt Calvert", "Jason Chimera", "Brandon Dubinsky", "Nick Foligno", "Ron Hainsey", "Boone Jenner", "Jack Johnson", "Seth Jones", "Rostislav Klesla", "Ryan Murray", "Rick Nash", "Artemi Panarin", "Kris Russell", "Geoff Sanderson", "David Savard", "Fedor Tyutin", "RJ Umberger", "Jakub Voracek", "David Vyborny", "Alexander Wennberg", "Zach Werenski", "James Wisniewski", "Nikolai Zherdev"};
	public static string[] FrSkatersDAL = {"Jamie Benn", "Philippe Boucher", "Trevor Daley", "Loui Eriksson", "Brent Gilchrist", "Alex Goligoski", "Bill Guerin", "Derian Hatcher", "Brett Hull", "John Klingberg", "Jamie Langenbrunner", "Jere Lehtinen", "Esa Lindell", "Richard Matvichuk", "Mike Modano", "Brenden Morrow", "Joe Nieuwendyk", "Alexander Radulov", "Mike Ribeiro", "Stephane Robidas", "Antoine Roussel", "Tyler Seguin", "Darryl Sydor", "Pat Verbeek", "Sergei Zubov"};
	public static string[] FrSkatersDET = {"Gary Bergman", "Steve Chiasson", "Daniel Cleary", "Paul Coffey", "Pavel Datsyuk", "Alex Delvecchio", "Sergei Fedorov", "Gerard Gallant", "Tomas Holmstrom", "Gordie Howe", "William Huber", "Red Kelly", "Niklas Kronwall", "Reed Larson", "Lynn Libett", "Nicklas Lidstrom", "Ted Lindsay", "Darren McCarty", "John Ogrodnick", "Marcel Pronovost", "Brian Rafalski", "Mickey Redmond", "Brendan Shanahan", "Steve Yzerman", "Henrik Zetterberg"};
	public static string[] FrSkatersEDM = {"Glenn Anderson", "Paul Coffey", "Leon Draisaitl", "Jordan Eberle", "Lee Fogolin", "Sam Gagner", "Tom Gilbert", "Randy Gregg", "Wayne Gretzky", "Taylor Hall", "Ales Hemsky", "Charlie Huddy", "Dave Hunter", "Jari Kurri", "Kevin Lowe", "Connor McDavid", "Mark Messier", "Boris Mironov", "Janne Niinimaa", "Darnell Nurse", "Craig Simpson", "Steve Smith", "Ryan Smyth", "Esa Tikkanen", "Doug Weight"};
	public static string[] FrSkatersFLA = {"Aleksander Barkov", "David Booth", "Jay Bouwmeester", "Pavel Bure", "Brian Campbell", "Evgeny Dadonov", "Radek Dvorak", "Aaron Ekblad", "Nathan Horton", "Jonathan Huberdeau", "Olli Jokinen", "Ed Jovanovski", "Viktor Kozlov", "Dmitri Kulikov", "Bill Lindsay", "Bryan McCabe", "Scott Mellanby", "Gord Murphy", "Rob Niedermayer", "Robert Svehla", "Vincent Trocheck", "Mike VanRyn", "Stephen Weiss", "Ray Whitney", "Keith Yandle"};
	public static string[] FrSkatersHAR = {"John Anderson", "Dave Babych", "Adam Burt", "Andrew Cassels", "Sylvain Cote", "Kevin Dineen", "Dean Evason", "Ray Ferraro", "Ron Francis", "Mark Howe", "Paul MacDermid", "Ray Neufeld", "Joel Quenneville", "Mike Rogers", "Ulf Samuelsson", "Geoff Sanderson", "Brad Shaw", "Risto Siltanen", "Al Sims", "Blaine Stoughton", "Dave Tippett", "Sylvain Turgeon", "Pat Verbeek", "Scott Young", "Zarley Zalapski"};
	public static string[] FrSkatersLAK = {"Bob Berry", "Rob Blake", "Dustin Brown", "Marcel Dionne", "Drew Doughty", "Steve Duchesne", "Jim Fox", "Alexander Frolov", "Butch Goring", "Wayne Gretzky", "Mark Hardy", "Anze Kopitar", "Jari Kurri", "Alec Martinez", "Marty McSorley", "Larry Murphy", "Mike Murphy", "Jake Muzzin", "Bernie Nicholls", "Zigmund Palffy", "Luc Robitaille", "Charlie Simmer", "Dave Taylor", "Lubomir Visnovsky", "Jay Wells"};
	public static string[] FrSkatersMNS = {"Fred Barrett", "Brian Bellows", "Neal Broten", "Dino Ciccarelli", "Jude Drouin", "Dave Gagner", "Barry Gibbs", "Curt Giles", "Bill Goldsworthy", "Danny Grant", "Craig Hartsburg", "Dennis Hextall", "Brian Lawton", "Al MacAdam", "Brad Maxwell", "Tom McCarthy", "Mike Modano", "Lou Nanne", "JeanPaul Parise", "Steve Payne", "Tom Reid", "Gordie Roberts", "Gary Sargent", "Bobby Smith", "Mark Tinordi"};
	public static string[] FrSkatersMNW = {"PierreMarc Bouchard", "Jonas Brodin", "Andrew Brunette", "Brent Burns", "Cal Clutterbuck", "Charlie Coyle", "Matt Dumba", "Marcus Foligno", "Marian Gaborik", "Mikael Granlund", "Martin Havlat", "Dany Heatley", "Kim Johnsson", "Mikko Koivu", "Filip Kuba", "Nino Niederreiter", "Zach Parise", "Jason Pominville", "Marco Scandella", "Nick Schultz", "Jared Spurgeon", "Eric Staal", "Ryan Suter", "Marek Zidlicky", "Jason Zucker"};
	public static string[] FrSkatersMON = {"Jean Beliveau", "Toe Blake", "Patrice Brisebois", "Chris Chelios", "Yvan Cournoyer", "Bernard Geoffrion", "Doug Harvey", "Saku Koivu", "Elmer Lach", "Guy Lafleur", "Jacques Laperriere", "Guy Lapointe", "Jacques Lemaire", "Pete Mahovlich", "Andrei Markov", "Dickie Moore", "Mats Naslund", "Claude Provost", "Henri Richard", "Maurice Richard", "Larry Robinson", "Serge Savard", "Steve Shutt", "PK Subban", "JeanClaude Tremblay"};
	public static string[] FrSkatersNAS = {"Viktor Arvidsson", "JeanPierre Dumont", "Mattias Ekholm", "Ryan Ellis", "Martin Erat", "Mike Fisher", "Filip Forsberg", "Dan Hamhuis", "Patric Hornqvist", "Ryan Johansen", "Greg Johnson", "Roman Josi", "Kevin Klein", "David Legwand", "James Neal", "Craig Smith", "PK Subban", "Steve Sullivan", "Ryan Suter", "Kimmo Timonen", "Scott Walker", "Shea Weber", "Colin Wilson", "Vitali Yachmenev", "Marek Zidlicky"};
	public static string[] FrSkatersNJD = {"Tommy Albelin", "Aaron Broten", "Joe Cirella", "Ken Daneyko", "Bruce Driver", "Patrik Elias", "Scott Gomez", "Andy Greene", "Adam Henrique", "Bobby Holik", "Jamie Langenbrunner", "John MacLean", "Paul Martin", "Randy McKay", "Kirk Muller", "Scott Niedermayer", "Zach Parise", "Brian Rafalski", "Stephane Richer", "Brian Rolston", "Damon Severson", "Scott Stevens", "Petr Sykora", "Pat Verbeek", "Travis Zajac"};
	public static string[] FrSkatersNYI = {"Josh Bailey", "Jason Blake", "Mike Bossy", "Bob Bourne", "Pat Flatley", "Clark Gillies", "Travis Hamonic", "Roman Hamrlik", "Billy Harris", "Kenny Jonsson", "Tomas Jonsson", "Derek King", "Pat LaFontaine", "Nick Leddy", "Anders Lee", "Jeff Norton", "Bob Nystrom", "Stefan Persson", "Denis Potvin", "Jean Potvin", "Mark Streit", "Brent Sutter", "John Tavares", "John Tonelli", "Bryan Trottier"};
	public static string[] FrSkatersNYR = {"Andy Bathgate", "Frank Boucher", "Neil Colville", "Bill Cook", "Bill Gadsby", "Rod Gilbert", "Adam Graves", "Ron Greschner", "Vic Hadfield", "Andy Hebenton", "Anders Hedberg", "Camille Henry", "Harry Howell", "Brian Leetch", "Dave Maloney", "Don Maloney", "Mark Messier", "Jim Neilson", "Brad Park", "James Patrick", "Jean Ratelle", "Reijo Ruotsalainen", "Tomas Sandstrom", "Walt Tkaczuk", "Steve Vickers"};
	public static string[] FrSkatersOTT = {"Daniel Alfredsson", "Radek Bonk", "Cody Ceci", "Thomas Chabot", "Zdeno Chara", "Mike Fisher", "Martin Havlat", "Dany Heatley", "Mike Hoffman", "Marian Hossa", "Erik Karlsson", "Filip Kuba", "Norm Maciver", "Shawn McEachern", "Andrej Meszaros", "Milan Michalek", "Chris Neil", "Chris Phillips", "Wade Redden", "Bobby Ryan", "Jason Spezza", "Mark Stone", "Kyle Turris", "Alexei Yashin", "Jason York"};
	public static string[] FrSkatersPHI = {"Bill Barber", "Tom Bladon", "Rod BrindAmour", "Bobby Clarke", "Sean Couturier", "Doug Crossman", "Bob Dailey", "Eric Desjardins", "Gary Dornhoefer", "Simon Gagne", "Claude Giroux", "Shayne Gostisbehere", "Mark Howe", "Tim Kerr", "Reggie Leach", "John LeClair", "Eric Lindros", "Rick MacLeish", "Brad McCrimmon", "Brian Propp", "Mark Recchi", "Kimmo Timonen", "Jakub Voracek", "Joe Watson", "Behn Wilson"};
	public static string[] FrSkatersPHO = {"Mikkel Boedker", "Jakob Chychrun", "Shane Doan", "Dallas Drake", "Christian Dvorak", "Oliver EkmanLarsson", "Alex Goligoski", "Martin Hanzal", "Mike Johnson", "Ed Jovanovski", "Clayton Keller", "Lauri Korpikoski", "Daymond Langkow", "Paul Mara", "Zbynek Michalek", "Derek Morris", "Ladislav Nagy", "Teppo Numminen", "Jeremy Roenick", "Keith Tkachuk", "Rick Tocchet", "Oleg Tverdovsky", "Antoine Vermette", "Radim Vrbata", "Keith Yandle"};
	public static string[] FrSkatersPIT = {"Syl Apps", "Doug Bodger", "Mike Bullard", "Randy Carlyle", "Paul Coffey", "Sidney Crosby", "Pascal Dupuis", "Bob Errey", "Ron Francis", "Sergei Gonchar", "Kevin Hatcher", "Jaromir Jagr", "Rick Kehoe", "Alexei Kovalev", "Chris Kunitz", "Mario Lemieux", "Kris Letang", "Evgeni Malkin", "Moe Mantha", "Larry Murphy", "Jean Pronovost", "Mark Recchi", "Ron Stackhouse", "Kevin Stevens", "Ryan Whitney"};
	public static string[] FrSkatersQUE = {"Jeff Brown", "Real Cloutier", "Alain Cote", "Steven Finn", "Paul Gillis", "Michel Goulet", "Alexei Gusarov", "Mike Hough", "Dale Hunter", "Pierre Lacroix", "Curtis Leschyshyn", "Mario Marois", "Randy Moller", "Owen Nolan", "Wilf Paiement", "Robert Picard", "Dave Pichette", "Jacques Richard", "Normand Rochefort", "Joe Sakic", "Anton Stastny", "Marian Stastny", "Peter Stastny", "Mats Sundin", "Marc Tardif"};
	public static string[] FrSkatersSJS = {"Dan Boyle", "Justin Braun", "Brent Burns", "Jonathan Cheechoo", "Ryan Clowe", "Logan Couture", "Vincent Damphousse", "Christian Ehrhoff", "Pat Falloon", "Jeff Friesen", "Scott Hannan", "Tomas Hertl", "Erik Karlsson", "Kevin Labanc", "Patrick Marleau", "Timo Meier", "Milan Michalek", "Owen Nolan", "Joe Pavelski", "Marcus Ragnarsson", "Mike Rathje", "Brad Stuart", "Marco Sturm", "Joe Thornton", "MarcEdouard Vlasic"};
	public static string[] FrSkatersSTL = {"Wayne Babych", "David Backes", "Red Berenson", "Jeff Brown", "Jack Brownschidle", "Pavol Demitra", "Bernie Federko", "Brett Hull", "Barret Jackman", "Al MacInnis", "Joe Mullen", "TJ Oshie", "Colton Parayko", "David Perron", "Alex Pietrangelo", "Barclay Plager", "Chris Pronger", "Rob Ramage", "Kevin Shattenkirk", "Alexander Steen", "Brian Sutter", "Vladimir Tarasenko", "Keith Tkachuk", "Pierre Turgeon", "Garry Unger"};
	public static string[] FrSkatersTBL = {"Dan Boyle", "Shawn Chambers", "Ruslan Fedotenko", "Roman Hamrlik", "Victor Hedman", "Tyler Johnson", "Alex Killorn", "Petr Klima", "Pavel Kubina", "Nikita Kucherov", "Vincent Lecavalier", "Ryan Malone", "Ryan McDonagh", "Fredrik Modin", "Ondrej Palat", "Vaclav Prospal", "Teddy Purcell", "Paul Ranger", "Brad Richards", "Cory Sarich", "Alexander Selivanov", "Mikhail Sergachev", "Steven Stamkos", "Martin StLouis", "Anton Stralman"};
	public static string[] FrSkatersTOR = {"John Anderson", "George Armstrong", "Wendel Clark", "Ron Ellis", "Todd Gill", "Tim Horton", "Al Iafrate", "Tomas Kaberle", "Red Kelly", "Ted Kennedy", "Dave Keon", "Phil Kessel", "Gary Leeman", "Frank Mahovlich", "Bryan McCabe", "Lanny McDonald", "Jim McKenny", "Bob Pulford", "Morgan Rielly", "Borje Salming", "Darryl Sittler", "Mats Sundin", "Darcy Tucker", "Ian Turnbull", "Rick Vaive"};
	public static string[] FrSkatersVAN = {"Todd Bertuzzi", "Kevin Bieksa", "Pavel Bure", "Alexandre Burrows", "Alexander Edler", "Thomas Gradin", "Ed Jovanovski", "Dennis Kearns", "Ryan Kesler", "Rick Lanz", "Don Lever", "Doug Lidster", "Trevor Linden", "Jyrki Lumme", "Kevin McCarthy", "Brendan Morrison", "Markus Naslund", "Mattias Ohlund", "Sami Salo", "Daniel Sedin", "Henrik Sedin", "Petri Skriko", "Stan Smyl", "Patrik Sundstrom", "Tony Tanti"};
	public static string[] FrSkatersWAS = {"Nicklas Backstrom", "Peter Bondra", "John Carlson", "Dave Christian", "Sylvain Cote", "Mike Gartner", "Sergei Gonchar", "Mike Green", "BengtAke Gustafsson", "Kevin Hatcher", "Dale Hunter", "Al Iafrate", "Calle Johansson", "Steve Konowalchuk", "Brooks Laich", "Rod Langway", "Kelly Miller", "Larry Murphy", "Adam Oates", "TJ Oshie", "Alexander Ovechkin", "Michal Pivonka", "Mike Ridley", "Alexander Semin", "Scott Stevens"};
	public static string[] FrSkatersWPG = {"Dave Babych", "Laurie Boschman", "Dustin Byfuglien", "Randy Carlyle", "Nikolaj Ehlers", "Dave Ellett", "Pat Elynuik", "Tobias Enstrom", "Dale Hawerchuk", "Phil Housley", "Patrik Laine", "Morris Lukowich", "Paul MacLean", "Moe Mantha", "Andrew McBain", "Brian Mullen", "Teppo Numminen", "Fredrik Olausson", "Mark Scheifele", "Teemu Selanne", "Doug Smail", "Thomas Steen", "Keith Tkachuk", "Jacob Trouba", "Blake Wheeler"};

	// Franchise Team Goalies
	public static string[] FrGoaliesANA = {"John Gibson", "JeanSebastian Giguere", "Guy Hebert", "Jonas Hiller"};
	public static string[] FrGoaliesATL = {"Johan Hedberg", "Kari Lehtonen", "Pasi Nurminen", "Ondrej Pavelec"};
	public static string[] FrGoaliesBOS = {"Gerry Cheevers", "Reggie Lemelin", "Andy Moog", "Tuukka Rask"};
	public static string[] FrGoaliesBUF = {"Dominik Hasek", "Clint Malarchuk", "Ryan Miller", "Daren Puppa"};
	public static string[] FrGoaliesCAL = {"Trevor Kidd", "Miikka Kiprusoff", "Roman Turek", "Mike Vernon"};
	public static string[] FrGoaliesCAR = {"Arturs Irbe", "Petr Mrazek", "Cam Ward", "Kevin Weekes"};
	public static string[] FrGoaliesCHI = {"Ed Belfour", "Corey Crawford", "Tony Esposito", "Glenn Hall"};
	public static string[] FrGoaliesCOL = {"David Aebischer", "Peter Budaj", "Patrick Roy", "Semyon Varlamov"};
	public static string[] FrGoaliesCBJ = {"Sergei Bobrovsky", "Marc Denis", "Pascal Leclaire", "Steve Mason"};
	public static string[] FrGoaliesDAL = {"Ed Belfour", "Kari Lehtonen", "Andy Moog", "Marty Turco"};
	public static string[] FrGoaliesDET = {"Tim Cheveldae", "Jimmy Howard", "Chris Osgood", "Terry Sawchuk"};
	public static string[] FrGoaliesEDM = {"Grant Fuhr", "Andy Moog", "Bill Ranford", "Tommy Salo"};
	public static string[] FrGoaliesFLA = {"Sean Burke", "Roberto Luongo", "John Vanbiesbrouck", "Tomas Vokoun"};
	public static string[] FrGoaliesHAR = {"Sean Burke", "Mike Liut", "Greg Millen", "Peter Sidorkiewicz"};
	public static string[] FrGoaliesLAK = {"Stephane Fiset", "Kelly Hrudey", "Jonathan Quick", "Rogatien Vachon"};
	public static string[] FrGoaliesMNS = {"Don Beaupre", "Jon Casey", "Cesare Maniago", "Gilles Meloche"};
	public static string[] FrGoaliesMNW = {"Niklas Backstrom", "Devan Dubnyk", "Manny Fernandez", "Dwayne Roloson"};
	public static string[] FrGoaliesMON = {"Ken Dryden", "Jacques Plante", "Carey Price", "Patrick Roy"};
	public static string[] FrGoaliesNAS = {"Mike Dunham", "Chris Mason", "Pekka Rinne", "Tomas Vokoun"};
	public static string[] FrGoaliesNJD = {"Martin Brodeur", "Chico Resch", "Cory Schneider", "Chris Terreri"};
	public static string[] FrGoaliesNYI = {"Rick DiPietro", "Kelly Hrudey", "Chico Resch", "Billy Smith"};
	public static string[] FrGoaliesNYR = {"Eddie Giacomin", "Henrik Lundqvist", "Mike Richter", "Gump Worsley"};
	public static string[] FrGoaliesOTT = {"Craig Anderson", "Patrick Lalime", "Damian Rhodes", "Ron Tugnutt"};
	public static string[] FrGoaliesPHI = {"Brian Boucher", "Ron Hextall", "Pelle Lindbergh", "Bernie Parent"};
	public static string[] FrGoaliesPHO = {"Ilya Bryzgalov", "Sean Burke", "Nikolai Khabibulin", "Mike Smith"};
	public static string[] FrGoaliesPIT = {"Tom Barrasso", "MarcAndre Fleury", "Denis Herron", "Ken Wregget"};
	public static string[] FrGoaliesQUE = {"Dan Bouchard", "Stephane Fiset", "Mario Gosselin", "Ron Tugnutt"};
	public static string[] FrGoaliesSTL = {"Jake Allen", "Grant Fuhr", "Curtis Joseph", "Mike Liut"};
	public static string[] FrGoaliesSJS = {"Arturs Irbe", "Martin Jones", "Evgeni Nabokov", "Antti Niemi"};
	public static string[] FrGoaliesTBL = {"Ben Bishop", "Nikolai Khabibulin", "Daren Puppa", "Andrei Vasilevskiy"};
	public static string[] FrGoaliesTOR = {"Johnny Bower", "Turk Broda", "Curtis Joseph", "Felix Potvin"};
	public static string[] FrGoaliesVAN = {"Richard Brodeur", "Dan Cloutier", "Roberto Luongo", "Kirk McLean"};
	public static string[] FrGoaliesWAS = {"Don Beaupre", "Braden Holtby", "Al Jensen", "Olaf Kolzig"};
	public static string[] FrGoaliesWPG = {"Bob Essensa", "Brian Hayward", "Connor Hellebuyck", "Ondrej Pavelec"};
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}