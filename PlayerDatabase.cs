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

	// In Game Information
	public static string GameplayPeriod;
	public static string GameplayPlay;
	public static string GameplayLine;
	public static string GameplayPossession;
	public static string GameplayP1Score;
	public static string GameplayP2Score;
	public static string GameplayP1Shots;
	public static string GameplayP2Shots;
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
	public static string[] SkatersANA = {"Simon Benoit", "Sam Carrick", "Trevor Carrick", "Maxime Comtois", "Nick Deslauriers", "Jamie Drysdale", "Cam Fowler", "Ryan Getzlaf", "Derek Grant", "Brendan Guhle", "Adam Henrique", "Max Jones", "Ryan Kesler", "Jacob Larsson", "Vinni Lettieri", "Hampus Lindholm", "Isac Lundestrom", "Josh Mahura", "Josh Manson", "Mason McTavish", "Sonny Milano", "Danny ORegan", "Greg Pateryn", "Brogan Rafferty", "Rickard Rakell", "Buddy Robinson", "Kevin Shattenkirk", "Jakob Silfverberg", "Sam Steel", "Troy Terry", "Alexander Volkov", "Trevor Zegras"};
	public static string[] SkatersARI = {"Jay Beagle", "Travis Boyd", "Kyle Capobianco", "Jakob Chychrun", "Lawson Crouse", "Cam Dineen", "Josh Doan", "Ryan Dzingel", "Loui Eriksson", "Hudson Fasching", "Christian Fischer", "Alex Galchenyuk", "Shayne Gostisbehere", "Barrett Hayton", "Dmitri Jaskin", "Jan Jenik", "Clayton Keller", "Phil Kessel", "Andrew Ladd", "Johan Larsson", "Ilya Lyubushkin", "Liam OBrien", "Antoine Roussel", "Nick Schmaltz", "Victor Soderstrom", "Blake Speers", "Anton Stralman", "Conor Timmins"};
	public static string[] SkatersBOS = {"Jack Ahcan", "Patrice Bergeron", "Anton Blidh", "Brandon Carlo", "Peter Cehlarik", "Connor Clifton", "Charlie Coyle", "Jake DeBrusk", "Steven Fogarty", "Nick Foligno", "Derek Forbort", "Jakob ForsbackaKarlsson", "Trent Frederic", "Matt Grzelcyk", "Taylor Hall", "Erik Haula", "Cameron Hughes", "Karson Kuhlman", "Mason Langenbrunner", "Curtis Lazar", "Tyler Lewington", "Brad Marchand", "Charlie McAvoy", "John Moore", "Tomas Nosek", "David Pastrnak", "Mike Reilly", "Zach Senyshyn", "Craig Smith", "Oskar Steen", "Jack Studnicka", "Urho Vaakanainen", "Chris Wagner", "Jakub Zboril"};
	public static string[] SkatersBUF = {"Rasmus Asplund", "Anders Bjork", "Jacob Bryson", "Will Butcher", "Drake Caggiula", "Dylan Cozens", "Rasmus Dahlin", "Brandon Davidson", "Cody Eakin", "Jack Eichel", "Zemgus Girgensons", "Robert Hagg", "John Hayden", "Vinnie Hinostroza", "Henri Jokiharju", "Miska Kukkonen", "Ryan MacInnis", "Sean Malone", "Colin Miller", "Casey Mittelstadt", "Brett Murray", "Kyle Okposo", "Victor Olofsson", "Lawrence Pilut", "Owen Power", "Mark Pysyk", "Arttu Ruotsalainen", "Mattias Samuelsson", "Jeff Skinner", "Tage Thompson", "Christian Wolanin"};
	public static string[] SkatersCAL = {"Rasmus Andersson", "Mikael Backlund", "Blake Coleman", "Nick DeSimone", "Dillon Dube", "Byron Froese", "Johnny Gaudreau", "Glenn Gawdin", "Kevin Gravel", "Erik Gudbranson", "Noah Hanifin", "Oliver Kylington", "Trevor Lewis", "Elias Lindholm", "Milan Lucic", "Connor Mackey", "Andrew Mangiapane", "Sean Monahan", "Matthew Phillips", "Tyler Pitlick", "Brad Richardson", "Brett Ritchie", "Adam Ruzicka", "Michael Stone", "Christopher Tanev", "Matthew Tkachuk", "Juuso Valimaki", "Andy Welinski", "Alexander Yelesin", "Nikita Zadorov"};
	public static string[] SkatersCAR = {"Sebastian Aho", "Ethan Bear", "Jalen Chatfield", "Ian Cole", "Tony DeAngelo", "Jack Drury", "Jesper Fast", "Jake Gardiner", "Josh Jacobs", "Seth Jarvis", "Joey Keane", "Yegor Korshkov", "Jesperi Kotkaniemi", "Maxime Lajoie", "Josh Leivo", "Maxim Letunov", "Steven Lorentz", "Jordan Martinook", "Martin Necas", "Nino Niederreiter", "Stefan Noesen", "Brett Pesce", "Brady Skjei", "Jaccob Slavin", "Brendan Smith", "CJ Smith", "Jordan Staal", "Derek Stepan", "Andrei Svechnikov", "Teuvo Teravainen", "Vincent Trocheck"};
	public static string[] SkatersCHI = {"Nicolas Beaudin", "Henrik Borgstrom", "Ryan Carpenter", "Brett Connolly", "Kirby Dach", "Colton Dach", "Alex DeBrincat", "Calvin DeHaan", "MacKenzie Entwistle", "Adam Gaudette", "Erik Gustafsson", "Brandon Hagel", "Mike Hardman", "Tyler Johnson", "Reese Johnson", "Seth Jones", "Caleb Jones", "Wyatt Kalynuk", "Patrick Kane", "Jujhar Khaira", "Dominik Kubalik", "Philipp Kurashev", "Jake McCabe", "Ian Mitchell", "Connor Murphy", "Alexander Nylander", "Alec Regula", "Andrew Shaw", "Riley Stillman", "Victor Stjernborg", "Dylan Strome", "Jonathan Toews"};
	public static string[] SkatersCOL = {"Andre Burakovsky", "Bowen Byram", "JT Compher", "Dennis Gilbert", "Samuel Girard", "Jordan Gross", "Darren Helm", "Jack Johnson", "Erik Johnson", "Tyson Jost", "Nazem Kadri", "Vladislav Kamenev", "Martin Kaut", "Gabriel Landeskog", "Kurtis MacDermid", "Jacob MacDonald", "Nathan MacKinnon", "Cale Makar", "Mikhail Maltsev", "Stefan Matteau", "Jayson Megna", "Keaton Middleton", "Ryan Murray", "Alex Newhook", "Valeri Nichushkin", "Logan OConnor", "Mikko Rantanen", "Kiefer Sherwood", "Dylan Sikura", "Devon Toews"};
	public static string[] SkatersCBJ = {"Gavin Bayreuther", "Jake Bean", "Emil Bemstrom", "Oliver Bjorkstrand", "Adam Boqvist", "Gabriel Carlsson", "Max Domi", "Josh Dunne", "Liam Foudy", "Brendan Gaunce", "Vladislav Gavrikov", "Nathan Gerbe", "Scott Harrington", "Boone Jenner", "Dean Kukan", "Sean Kuraly", "Patrik Laine", "Gustav Nyquist", "Andrew Peeke", "Zac Rinaldo", "Eric Robinson", "Jack Roslovic", "Cole Sillinger", "Kevin Stenlund", "Alexandre Texier", "Calvin Thurkauf", "Jakub Voracek", "Zach Werenski"};
	public static string[] SkatersDAL = {"Jamie Benn", "Andreas Borgman", "Nick Caamano", "Blake Comeau", "Ty Dellandrea", "Radek Faksa", "Rhett Gardner", "Luke Glendening", "Denis Gurianov", "Jani Hakanpaa", "Joel Hanley", "Miro Heiskanen", "Roope Hintz", "Tanner Kero", "Joel Kiviranta", "John Klingberg", "Joel LEsperance", "Esa Lindell", "Joe Pavelski", "Jacob Peterson", "Alex Petrovic", "Alexander Radulov", "Michael Raffl", "Jason Robertson", "Tyler Seguin", "Andrej Sekera", "Ryan Suter", "Riley Tufte"};
	public static string[] SkatersDET = {"Riley Barber", "Tyler Bertuzzi", "Danny DeKeyser", "Adam Erne", "Robby Fabbri", "Sam Gagner", "Taro Hirose", "Filip Hronek", "Dylan Larkin", "Brian Lashoff", "Nick Leddy", "Gustav Lindstrom", "Ryan Murphy", "Vladislav Namestnikov", "Jordan Oesterle", "Michael Rasmussen", "Lucas Raymond", "Dan Renouf", "Carter Rowney", "Moritz Seider", "Givani Smith", "Marc Staal", "Troy Stecher", "Mitchell Stephens", "Pius Suter", "Joe Veleno", "Jakub Vrana", "Luke Witkowski", "Filip Zadina"};
	public static string[] SkatersEDM = {"Josh Archibald", "Tyson Barrie", "Tyler Benson", "Evan Bouchard", "Skyler BrindAmour", "Cody Ceci", "Leon Draisaitl", "Warren Foegele", "Zach Hyman", "Zack Kassian", "Duncan Keith", "Oscar Klefbom", "Slater Koekkoek", "William Lagesson", "Cooper Marody", "Connor McDavid", "Ryan McLeod", "Ryan NugentHopkins", "Darnell Nurse", "Brendan Perlini", "Jesse Puljujarvi", "Kris Russell", "Derek Ryan", "Devin Shore", "Kyle Turris", "Kailer Yamamoto"};
	public static string[] SkatersFLA = {"Noel Acciari", "Aleksander Barkov", "Sam Bennett", "Lucas Carlsson", "Kevin Connauton", "Zac Dalpe", "Grigory Denisenko", "Anthony Duclair", "Aaron Ekblad", "Gustav Forsling", "Radko Gudas", "Aleksi Heponiemi", "Patric Hornqvist", "Jonathan Huberdeau", "Olli Juolevi", "Matt Kiersted", "Ryan Lomberg", "Anton Lundell", "Eetu Luostarinen", "Maxim Mamin", "Mason Marchment", "Brandon Montour", "Markus Nutivaara", "Sam Reinhart", "Aleksi Saarela", "Joe Thornton", "Owen Tippett", "Frank Vatrano", "Carter Verhaeghe", "MacKenzie Weegar"};
	public static string[] SkatersLAK = {"Michael Anderson", "Jaret AndersonDolan", "Lias Andersson", "Viktor Arvidsson", "Andreas Athanasiou", "Tobias Bjornfot", "Dustin Brown", "Quinton Byfield", "Kale Clague", "Phillip Danault", "Drew Doughty", "Alexander Edler", "Martin Frk", "Carl Grundstrom", "Alex Iafallo", "Arthur Kaliyev", "Adrian Kempe", "Anze Kopitar", "Rasmus Kupari", "Brendan Lemieux", "Blake Lizotte", "Olli Maatta", "Trevor Moore", "Matt Roy", "Austin Strand", "Vladimir Tkachev", "TJ Tynan", "Gabriel Vilardi", "Austin Wagner", "Sean Walker"};
	public static string[] SkatersMIN = {"Calen Addison", "Jordie Benn", "Nick Bjugstad", "Matt Boldy", "Jonas Brodin", "Joseph Cramarossa", "Kevin Czuczman", "Matt Dumba", "Joel ErikssonEk", "Kevin Fiala", "Marcus Foligno", "Frederick Gaudreau", "Alex Goligoski", "Jordan Greenway", "Ryan Hartman", "Joe Hicketts", "Kirill Kaprizov", "Dmitri Kulikov", "Dakota Mermis", "Jon Merrill", "Rem Pitlick", "Victor Rask", "Kyle Rau", "Marco Rossi", "Jared Spurgeon", "Nico Sturm", "Dominic Turgeon", "Mats Zuccarello"};
	public static string[] SkatersMON = {"Josh Anderson", "Joel Armia", "Louis Belpedio", "Alex Belzile", "Adam Brooks", "Paul Byron", "Cole Caufield", "Ben Chiarot", "Laurent Dauphin", "JeanSebastien Dea", "Jonathan Drouin", "Christian Dvorak", "Joel Edmundson", "Jake Evans", "Brendan Gallagher", "Mike Hoffman", "Brett Kulak", "Artturi Lehkonen", "Otto Leskinen", "Sami Niku", "Xavier Ouellet", "Cedric Paquette", "Mathieu Perreault", "Jeff Petry", "Ryan Poehling", "Alexander Romanov", "David Savard", "Nick Suzuki", "Tyler Toffoli", "Lukas Vejdemo", "Shea Weber", "Chris Wideman", "Jesse Ylonen"};
	public static string[] SkatersNAS = {"Frederic Allard", "Matt Benning", "Mark Borowiecki", "Alexandre Carrier", "Nick Cousins", "Jeremy Davies", "Matt Duchene", "Mattias Ekholm", "Dante Fabbro", "David Farrance", "Filip Forsberg", "Cody Glass", "Mikael Granlund", "Rocco Grimaldi", "Ben Harpur", "Tanner Jeannot", "Ryan Johansen", "Roman Josi", "Luke Kunin", "Matt Luff", "Michael McCarron", "Philippe Myers", "Mathieu Olivier", "Anthony Richard", "Colton Sissons", "Cole Smith", "Matt Tennyson", "Eeli Tolvanen", "Yakov Trenin"};
	public static string[] SkatersNJD = {"Kevin Bahl", "Jesper Boqvist", "Jesper Bratt", "Chase DeLeo", "Nolan Foote", "Joe Gambardella", "Frederik Gauthier", "Ryan Graves", "AJ Greer", "Dougie Hamilton", "Nico Hischier", "Jack Hughes", "Christian Jaros", "Janne Kuokkanen", "Michael McLeod", "Dawson Mercer", "Damon Severson", "Yegor Sharangovich", "Jonas Siegenthaler", "Ty Smith", "Marian Studenic", "PK Subban", "Tomas Tatar", "Tyce Thompson", "Jimmy Vesey", "Colton White", "Miles Wood", "Pavel Zacha"};
	public static string[] SkatersNYI = {"SJ Aho", "Andy Andreoff", "Josh Bailey", "Cole Bardreau", "Mathew Barzal", "Anthony Beauvillier", "Kieffer Bellows", "Johnny Boychuk", "Zdeno Chara", "Casey Cizikas", "Cal Clutterbuck", "Austin Czarnik", "Michael DalColle", "Noah Dobson", "Andy Greene", "Thomas Hickey", "Ross Johnston", "Otto Koivula", "Leo Komarov", "Paul LaDue", "Anders Lee", "Matt Martin", "Scott Mayfield", "Brock Nelson", "JeanGabriel Pageau", "Kyle Palmieri", "Richard Panik", "Zach Parise", "Adam Pelech", "Ryan Pulock", "Oliver Wahlstrom"};
	public static string[] SkatersNYR = {"Morgan Barron", "Anthony Bitetto", "Sammy Blais", "Jonny Brodzinski", "Filip Chytil", "Adam Fox", "Julien Gauthier", "Tim Gettinger", "Barclay Goodrow", "Anthony Greco", "Libor Hajek", "Dryden Hunt", "Zac Jones", "Kaapo Kakko", "Vitali Kravtsov", "Chris Kreider", "Alexis Lafreniere", "Ryan Lindgren", "Nils Lundkvist", "Greg McKegg", "KAndre Miller", "Patrik Nemeth", "Artemi Panarin", "Ryan Reaves", "Tarmo Reunanen", "Justin Richards", "Kevin Rooney", "Ryan Strome", "Jarred Tinordi", "Jacob Trouba", "Mika Zibanejad"};
	public static string[] SkatersOTT = {"Pontus Aberg", "Vitaly Abramov", "Andrew Agozzino", "Olle Alsing", "Drake Batherson", "Jacob BernardDocker", "Clark Bishop", "Erik Brannstrom", "Connor Brown", "Josh Brown", "Thomas Chabot", "Michael DelZotto", "Tyler Ennis", "Alex Formenton", "Dillon Heatherington", "Nick Holden", "Parker Kelly", "Victor Mete", "Josh Norris", "Nick Paul", "Shane Pinto", "Scott Sabourin", "Zach Sanford", "Logan Shaw", "Kole Sherwood", "Tim Stützle", "Chris Tierney", "Brady Tkachuk", "Austin Watson", "Colin White", "Nikita Zaitsev", "Artyom Zub"};
	public static string[] SkatersPHI = {"Wade Allison", "Cam Atkinson", "Nicolas AubeKubel", "Derick Brassard", "Justin Braun", "Patrick Brown", "Connor Bunnaman", "Jackson Cates", "Adam Clendening", "Sean Couturier", "Ryan Ellis", "Joel Farabee", "Morgan Frost", "Claude Giroux", "Kevin Hayes", "David Kase", "Travis Konecny", "Tanner Laczynski", "Scott Laughton", "Oskar Lindblom", "Zack MacEwen", "Gerald Mayhew", "Samuel Morin", "Ivan Provorov", "Rasmus Ristolainen", "German Rubtsov", "Travis Sanheim", "Nick Seeler", "Maxim Sushko", "Nate Thompson", "James VanRiemsdyk", "Mikhail Vorobyov", "Keith Yandle", "Cam York", "Yegor Zamula"};
	public static string[] SkatersPIT = {"Anthony Angello", "Zach AstonReese", "Teddy Blueger", "Brian Boyle", "Jeff Carter", "Michael Chaput", "Sidney Crosby", "Brian Dumoulin", "Taylor Fedun", "Mark Friedman", "Jake Guentzel", "Danton Heinen", "PierreOlivier Joseph", "Kasperi Kapanen", "Sam Lafferty", "Kris Letang", "Evgeni Malkin", "John Marino", "Mike Matheson", "Brock McGinn", "Drew OConnor", "Marcus Pettersson", "Juuso Riikola", "Evan Rodrigues", "Chad Ruhwedel", "Bryan Rust", "Dominik Simon", "Radim Zohorna", "Jason Zucker"};
	public static string[] SkatersSTL = {"Ivan Barbashev", "Robert Bortuzzo", "Tyler Bozak", "Logan Brown", "Pavel Buchnevich", "Kyle Clifford", "Justin Faulk", "Dakota Joshua", "Klim Kostin", "Torey Krug", "Jordan Kyrou", "MacKenzie MacEachern", "Niko Mikkola", "James Neal", "Ryan OReilly", "Colton Parayko", "Matthew Peca", "David Perron", "Calle Rosen", "Brandon Saad", "Steve Santini", "Marco Scandella", "Brayden Schenn", "Oskar Sundqvist", "Vladimir Tarasenko", "Robert Thomas", "Nathan Walker", "Jake Walman"};
	public static string[] SkatersSJS = {"Rudolfs Balcers", "Alexander Barabanov", "Joachim Blichfeld", "Nick Bonino", "Brent Burns", "Alexander Chmelevski", "Andrew Cogliano", "Logan Couture", "Jonathan Dahlen", "William Eklund", "Mario Ferraro", "Jonah Gadjovich", "Dylan Gambrell", "Noah Gregor", "Tomas Hertl", "Evander Kane", "Erik Karlsson", "Joel Kellman", "Nikolai Knyzhov", "Kevin Labanc", "John Leonard", "Jaycob Megna", "Timo Meier", "Nicolas Meloche", "Nick Merkley", "Jacob Middleton", "Matt Nieto", "Brinson Pasichnuk", "Lane Pederson", "Radim Simek", "MarcEdouard Vlasic"};
	public static string[] SkatersSEA = {"Mason Appleton", "Alex BarreBoulet", "Nathan Bastian", "Colin Blackwell", "Will Borgen", "Connor Carrick", "Ryan Donato", "Joonas Donskoi", "Vince Dunn", "Jordan Eberle", "Haydn Fleury", "Cale Fleury", "Morgan Geekie", "Mark Giordano", "Yanni Gourde", "Calle Jarnkrok", "Marcus Johansson", "Adam Larsson", "Jeremy Lauzon", "Kole Lind", "Jared McCann", "Max McCormick", "Jamie Oleksiak", "Gustav Olofsson", "Jaden Schwartz", "Riley Sheahan", "Carson Soucy", "Brandon Tanev", "Alexander True ", "Carsen Twarynski", "Alexander Wennberg"};
	public static string[] SkatersTBL = {"PierreEdouard Bellemare", "Zach Bogosian", "Erik Cernak", "Anthony Cirelli", "Fredrik Claesson", "Ross Colton", "Gabriel Dumont", "Remi Elie", "Cal Foote", "Victor Hedman", "Charles Hudon", "Mathieu Joseph", "Alex Killorn", "Nikita Kucherov", "Pat Maroon", "Ryan McDonagh", "Ondrej Palat", "Corey Perry", "Brayden Point", "Jan Rutta", "Brent Seabrook", "Mikhail Sergachev", "Gemel Smith", "Steven Stamkos", "Andrej Sustr", "Daniel Walcott"};
	public static string[] SkatersTOR = {"Mike Amadio", "Joey Anderson", "Alex Biega", "TJ Brodie", "Michael Bunting", "Carl Dahlstrom", "Travis Dermott", "Pierre Engvall", "Kurtis Gabriel", "Justin Holl", "David Kampf", "Ondrej Kase", "Alexander Kerfoot", "Timothy Liljegren", "Denis Malgin", "Mitchell Marner", "Auston Matthews", "Brennan Menell", "Ilya Mikheyev", "Jake Muzzin", "William Nylander", "Morgan Rielly", "Nick Ritchie", "Nick Robertson", "Rasmus Sandin", "Brett Seney", "Wayne Simmonds", "Jason Spezza", "John Tavares"};
	public static string[] SkatersVAN = {"Justin Bailey", "Brock Boeser", "Madison Bowey", "Guillaume Brisebois", "Kyle Burroughs", "Alex Chiasson", "Jason Dickinson", "Phil DiGiuseppe", "Justin Dowling", "Sheldon Dries", "Oliver EkmanLarsson", "Michael Ferland", "Conor Garland", "Travis Hamonic", "Matthew Highmore", "Nils Hoglander", "Bo Horvat", "Quinn Hughes", "Brad Hunt", "Noah Juulsen", "Brady Keeper", "Juho Lammikko", "Will Lockwood", "JT Miller", "Tyler Motte", "Tyler Myers", "Tanner Pearson", "Nic Petan", "Elias Pettersson", "Vasily Podkolzin", "Tucker Poolman", "Jack Rathbone", "Sheldon Rempal", "Luke Schenn", "Brandon Sutter"};
	public static string[] SkatersVGK = {"Sven Bartschi", "Jake Bischoff", "William Carrier", "Dylan Coghlan", "Evgeny Dadonov", "Nicolas Hague", "Brett Howden", "Mattias Janmark", "William Karlsson", "Keegan Kolesar", "Peyton Krebs", "Jonathan Marchessault", "Alec Martinez", "Brayden McNabb", "Max Pacioretty", "Nolan Patrick", "Alex Pietrangelo", "Gage Quinney", "Nicolas Roy", "Reilly Smith", "Chandler Stephenson", "Mark Stone", "Shea Theodore", "Alex Tuch", "Zach Whitecloud"};
	public static string[] SkatersWAS = {"Nicklas Backstrom", "John Carlson", "Dennis Cholowski", "Nic Dowd", "Lars Eller", "Martin Fehervary", "Carl Hagelin", "Garnet Hathaway", "Matt Irwin", "Nick Jensen", "Michal Kempny", "Evgeny Kuznetsov", "Hendrix Lapierre", "Beck Malenstyn", "Anthony Mantha", "Dylan McIlrath", "Connor McMichael", "Dmitry Orlov", "TJ Oshie", "Alexander Ovechkin", "Justin Schultz", "Michael Sgarbossa", "Conor Sheary", "Daniel Sprong", "Trevor VanRiemsdyk", "Tom Wilson"};
	public static string[] SkatersWPG = {"Nathan Beaulieu", "Kyle Connor", "Andrew Copp", "Dylan DeMelo", "Brenden Dillon", "PierreLuc Dubois", "Nikolaj Ehlers", "David Gustafsson", "Jansen Harkins", "Ville Heinola", "Luke Johnson", "Bryan Little", "Adam Lowry", "Josh Morrissey", "Riley Nash", "Nelson Nogier", "Cole Perfetti", "Neal Pionk", "Austin Poganski", "Mark Scheifele", "Nate Schmidt", "Logan Stanley", "Paul Stastny", "CJ Suess", "Evgeny Svechnikov", "Dominic Toninato", "Kristian Vesalainen", "Blake Wheeler"};

	// Team Goalies
	public static string[] GoaliesANA = {"John Gibson", "Anthony Stolarz"};
	public static string[] GoaliesARI = {"Carter Hutton", "Josef Korenar", "Ivan Prosvetov", "Scott Wedgewood"};
	public static string[] GoaliesBOS = {"Troy Grosenick", "Tuukka Rask", "Jeremy Swayman", "Linus Ullmark"};
	public static string[] GoaliesBUF = {"Craig Anderson", "Aaron Dell", "UkkoPekka Luukkonen", "Dustin Tokarski"};
	public static string[] GoaliesCAL = {"Jacob Markstrom", "Daniel Vladar", "Adam Werner"};
	public static string[] GoaliesCAR = {"Frederik Andersen", "Alex Lyon", "Antti Raanta"};
	public static string[] GoaliesCHI = {"Colin Delia", "MarcAndre Fleury", "Kevin Lankinen", "Malcolm Subban"};
	public static string[] GoaliesCOL = {"Pavel Francouz", "Jonas Johansson", "Darcy Kuemper", "Hunter Miska"};
	public static string[] GoaliesCBJ = {"Joonas Korpisalo", "Elvis Merzlikins"};
	public static string[] GoaliesDAL = {"Ben Bishop", "Landon Bow", "Braden Holtby", "Anton Khudobin", "Jake Oettinger"};
	public static string[] GoaliesDET = {"Kaden Fulcher", "Thomas Greiss", "Alex Nedeljkovic", "Calvin Pickard"};
	public static string[] GoaliesEDM = {"Mikko Koskinen", "Stuart Skinner", "Mike Smith", "Alex Stalock"};
	public static string[] GoaliesFLA = {"Sergei Bobrovsky", "Christopher Gibson", "Spencer Knight"};
	public static string[] GoaliesLAK = {"Cal Petersen", "Jonathan Quick", "Garret Sparks"};
	public static string[] GoaliesMIN = {"Kaapo Kahkonen", "Cam Talbot"};
	public static string[] GoaliesMON = {"Jake Allen", "Samuel Montembeault", "Carey Price", "Cayden Primeau"};
	public static string[] GoaliesNAS = {"David Rittich", "Juuse Saros"};
	public static string[] GoaliesNJD = {"Jonathan Bernier", "Mackenzie Blackwood", "Gilles Senn"};
	public static string[] GoaliesNYI = {"Cory Schneider", "Ilya Sorokin", "Semyon Varlamov"};
	public static string[] GoaliesNYR = {"Alexandar Georgiev", "Keith Kinkaid", "Igor Shesterkin"};
	public static string[] GoaliesOTT = {"Anton Forsberg", "Filip Gustavsson", "Matt Murray"};
	public static string[] GoaliesPHI = {"Carter Hart", "Martin Jones"};
	public static string[] GoaliesPIT = {"Casey DeSmith", "Louis Domingue", "Tristan Jarry"};
	public static string[] GoaliesSTL = {"Jordan Binnington", "Ville Husso", "Charlie Lindgren"};
	public static string[] GoaliesSJS = {"Adin Hill", "Alexei Melnichuk", "James Reimer"};
	public static string[] GoaliesSEA = {"Antoine Bibeau", "Joey Daccord", "Chris Driedger", "Philipp Grubauer"};
	public static string[] GoaliesTBL = {"Brian Elliott", "Maxime Lagace", "Andrei Vasilevskiy"};
	public static string[] GoaliesTOR = {"Jack Campbell", "Michael Hutchinson", "Petr Mrazek"};
	public static string[] GoaliesVAN = {"Thatcher Demko", "Michael DiPietro", "Jaroslav Halak"};
	public static string[] GoaliesVGK = {"Laurent Brossoit", "Robin Lehner", "Logan Thompson"};
	public static string[] GoaliesWAS = {"Pheonix Copley", "Ilya Samsonov", "Vitek Vanecek"};
	public static string[] GoaliesWPG = {"Eric Comrie", "Connor Hellebuyck"};

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