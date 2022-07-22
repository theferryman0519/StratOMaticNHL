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

public class GStatsPenalty : MonoBehaviour {
		
// ---------------------------------------- START: LIST OF VARIABLES ----------------------------------------
// --------------- PUBLIC VARIABLES ---------------
	
	
// --------------- PRIVATE VARIABLES ---------------
	
	
// --------------- STATIC VARIABLES ---------------
	public static Dictionary <string, string> PlayerGStatsPenalty = new Dictionary<string, string>();
	public static Dictionary <string, string> FrPlayerGStatsPenalty = new Dictionary<string, string>();
	
// ---------------------------------------- END: LIST OF VARIABLES ----------------------------------------
// ---------------------------------------- START: CALLING OTHER SCRIPTS ----------------------------------------
	
	
// ---------------------------------------- END: CALLING OTHER SCRIPTS ----------------------------------------
// ---------------------------------------- START: INITIAL FUNCTIONS ----------------------------------------
// --------------- START FUNCTION ---------------
	void Start() {
		
	}
	
// --------------- AWAKE FUNCTION ---------------
	void Awake() {
		PlayerGStatsPenalty.Add("Lukas Dostal","D");
PlayerGStatsPenalty.Add("John Gibson","C");
PlayerGStatsPenalty.Add("Thomas Hodges","D");
PlayerGStatsPenalty.Add("Anthony Stolarz","D");
PlayerGStatsPenalty.Add("Josef Korenar","D");
PlayerGStatsPenalty.Add("Ivan Prosvetov","D");
PlayerGStatsPenalty.Add("Harri Sateri","AA");
PlayerGStatsPenalty.Add("Karel Vejmelka","D");
PlayerGStatsPenalty.Add("Troy Grosenick","D");
PlayerGStatsPenalty.Add("Jeremy Swayman","D");
PlayerGStatsPenalty.Add("Linus Ullmark","D");
PlayerGStatsPenalty.Add("Craig Anderson","D");
PlayerGStatsPenalty.Add("Eric Comrie","D");
PlayerGStatsPenalty.Add("Michael Houser","D");
PlayerGStatsPenalty.Add("UkkoPekka Luukkonen","D");
PlayerGStatsPenalty.Add("Malcolm Subban","D");
PlayerGStatsPenalty.Add("Dustin Tokarski","C");
PlayerGStatsPenalty.Add("Jacob Markstrom","D");
PlayerGStatsPenalty.Add("Daniel Vladar","D");
PlayerGStatsPenalty.Add("Adam Werner","D");
PlayerGStatsPenalty.Add("Frederik Andersen","D");
PlayerGStatsPenalty.Add("Pyotr Kochetkov","D");
PlayerGStatsPenalty.Add("Jack LaFontaine","D");
PlayerGStatsPenalty.Add("Alex Lyon","D");
PlayerGStatsPenalty.Add("Antti Raanta","D");
PlayerGStatsPenalty.Add("JeanFrancois Berube","B");
PlayerGStatsPenalty.Add("Joonas Korpisalo","D");
PlayerGStatsPenalty.Add("Elvis Merzlikins","D");
PlayerGStatsPenalty.Add("Daniil Tarasov","D");
PlayerGStatsPenalty.Add("Collin Delia","D");
PlayerGStatsPenalty.Add("Kevin Lankinen","B");
PlayerGStatsPenalty.Add("Petr Mrazek","C");
PlayerGStatsPenalty.Add("Arvid Soderblom","D");
PlayerGStatsPenalty.Add("Alex Stalock","D");
PlayerGStatsPenalty.Add("Justus Annunen","C");
PlayerGStatsPenalty.Add("Pavel Francouz","D");
PlayerGStatsPenalty.Add("Alexandar Georgiev","C");
PlayerGStatsPenalty.Add("Hunter Miska","D");
PlayerGStatsPenalty.Add("Landon Bow","D");
PlayerGStatsPenalty.Add("Braden Holtby","D");
PlayerGStatsPenalty.Add("Anton Khudobin","C");
PlayerGStatsPenalty.Add("Jake Oettinger","D");
PlayerGStatsPenalty.Add("Scott Wedgewood","D");
PlayerGStatsPenalty.Add("Kaden Fulcher","D");
PlayerGStatsPenalty.Add("Magnus Hellberg","D");
PlayerGStatsPenalty.Add("Ville Husso","D");
PlayerGStatsPenalty.Add("Alex Nedeljkovic","C");
PlayerGStatsPenalty.Add("Jack Campbell","D");
PlayerGStatsPenalty.Add("Mikko Koskinen","D");
PlayerGStatsPenalty.Add("Calvin Pickard","C");
PlayerGStatsPenalty.Add("Stuart Skinner","D");
PlayerGStatsPenalty.Add("Mike Smith","A");
PlayerGStatsPenalty.Add("Sergei Bobrovsky","D");
PlayerGStatsPenalty.Add("Christopher Gibson","D");
PlayerGStatsPenalty.Add("Jonas Johansson","D");
PlayerGStatsPenalty.Add("Spencer Knight","D");
PlayerGStatsPenalty.Add("Pheonix Copley","D");
PlayerGStatsPenalty.Add("Cal Petersen","D");
PlayerGStatsPenalty.Add("Jonathan Quick","D");
PlayerGStatsPenalty.Add("Garret Sparks","D");
PlayerGStatsPenalty.Add("MarcAndre Fleury","C");
PlayerGStatsPenalty.Add("Filip Gustavsson","D");
PlayerGStatsPenalty.Add("Jake Allen","D");
PlayerGStatsPenalty.Add("Andrew Hammond","D");
PlayerGStatsPenalty.Add("Michael McNiven","D");
PlayerGStatsPenalty.Add("Samuel Montembeault","D");
PlayerGStatsPenalty.Add("Carey Price","D");
PlayerGStatsPenalty.Add("Cayden Primeau","D");
PlayerGStatsPenalty.Add("Connor Ingram","D");
PlayerGStatsPenalty.Add("Juuse Saros","C");
PlayerGStatsPenalty.Add("Jonathan Bernier","D");
PlayerGStatsPenalty.Add("Mackenzie Blackwood","D");
PlayerGStatsPenalty.Add("Nico Daws","D");
PlayerGStatsPenalty.Add("Akira Schmid","D");
PlayerGStatsPenalty.Add("Gilles Senn","D");
PlayerGStatsPenalty.Add("Vitek Vanecek","D");
PlayerGStatsPenalty.Add("Cory Schneider","D");
PlayerGStatsPenalty.Add("Ilya Sorokin","D");
PlayerGStatsPenalty.Add("Semyon Varlamov","D");
PlayerGStatsPenalty.Add("Louis Domingue","C");
PlayerGStatsPenalty.Add("Jaroslav Halak","D");
PlayerGStatsPenalty.Add("Adam Huska","D");
PlayerGStatsPenalty.Add("Keith Kinkaid","D");
PlayerGStatsPenalty.Add("Igor Shesterkin","C");
PlayerGStatsPenalty.Add("Anton Forsberg","D");
PlayerGStatsPenalty.Add("Mads Sogaard","D");
PlayerGStatsPenalty.Add("Cam Talbot","B");
PlayerGStatsPenalty.Add("Carter Hart","D");
PlayerGStatsPenalty.Add("Felix Sandstrom","D");
PlayerGStatsPenalty.Add("Casey DeSmith","D");
PlayerGStatsPenalty.Add("Tristan Jarry","C");
PlayerGStatsPenalty.Add("Antoine Bibeau","D");
PlayerGStatsPenalty.Add("Joey Daccord","C");
PlayerGStatsPenalty.Add("Chris Driedger","D");
PlayerGStatsPenalty.Add("Philipp Grubauer","D");
PlayerGStatsPenalty.Add("Martin Jones","D");
PlayerGStatsPenalty.Add("Aaron Dell","D");
PlayerGStatsPenalty.Add("Adin Hill","D");
PlayerGStatsPenalty.Add("Kaapo Kahkonen","C");
PlayerGStatsPenalty.Add("James Reimer","D");
PlayerGStatsPenalty.Add("Zachary Sawchenko","D");
PlayerGStatsPenalty.Add("Jordan Binnington","D");
PlayerGStatsPenalty.Add("Jon Gillies","D");
PlayerGStatsPenalty.Add("Thomas Greiss","D");
PlayerGStatsPenalty.Add("Joel Hofer","D");
PlayerGStatsPenalty.Add("Hugo Alnefelt","D");
PlayerGStatsPenalty.Add("Brian Elliott","C");
PlayerGStatsPenalty.Add("Maxime Lagace","D");
PlayerGStatsPenalty.Add("Alexei Melnichuk","D");
PlayerGStatsPenalty.Add("Andrei Vasilevskiy","D");
PlayerGStatsPenalty.Add("Michael Hutchinson","D");
PlayerGStatsPenalty.Add("Carter Hutton","C");
PlayerGStatsPenalty.Add("Erik Kallgren","D");
PlayerGStatsPenalty.Add("Matt Murray","D");
PlayerGStatsPenalty.Add("Ilya Samsonov","D");
PlayerGStatsPenalty.Add("Joseph Woll","D");
PlayerGStatsPenalty.Add("Thatcher Demko","D");
PlayerGStatsPenalty.Add("Michael DiPietro","D");
PlayerGStatsPenalty.Add("Spencer Martin","D");
PlayerGStatsPenalty.Add("Laurent Brossoit","D");
PlayerGStatsPenalty.Add("Robin Lehner","D");
PlayerGStatsPenalty.Add("Logan Thompson","D");
PlayerGStatsPenalty.Add("Zachary Fucale","D");
PlayerGStatsPenalty.Add("Darcy Kuemper","B");
PlayerGStatsPenalty.Add("Charlie Lindgren","D");
PlayerGStatsPenalty.Add("Connor Hellebuyck","D");
PlayerGStatsPenalty.Add("David Rittich","C");

FrPlayerGStatsPenalty.Add("John GibsonANA","D");
FrPlayerGStatsPenalty.Add("JeanSebastian GiguereANA","C");
FrPlayerGStatsPenalty.Add("Guy HebertANA","D");
FrPlayerGStatsPenalty.Add("Jonas HillerANA","D");
FrPlayerGStatsPenalty.Add("Johan HedbergATL","C");
FrPlayerGStatsPenalty.Add("Kari LehtonenATL","D");
FrPlayerGStatsPenalty.Add("Pasi NurminenATL","C");
FrPlayerGStatsPenalty.Add("Ondrej PavelecATL","D");
FrPlayerGStatsPenalty.Add("Gerry CheeversBOS","A");
FrPlayerGStatsPenalty.Add("Reggie LemelinBOS","C");
FrPlayerGStatsPenalty.Add("Andy MoogBOS","B");
FrPlayerGStatsPenalty.Add("Tuukka RaskBOS","D");
FrPlayerGStatsPenalty.Add("Dominik HasekBUF","C");
FrPlayerGStatsPenalty.Add("Clint MalarchukBUF","B");
FrPlayerGStatsPenalty.Add("Ryan MillerBUF","D");
FrPlayerGStatsPenalty.Add("Daren PuppaBUF","D");
FrPlayerGStatsPenalty.Add("Trevor KiddCAL","D");
FrPlayerGStatsPenalty.Add("Miikka KiprusoffCAL","D");
FrPlayerGStatsPenalty.Add("Roman TurekCAL","D");
FrPlayerGStatsPenalty.Add("Mike VernonCAL","B");
FrPlayerGStatsPenalty.Add("Arturs IrbeCAR","D");
FrPlayerGStatsPenalty.Add("Petr MrazekCAR","D");
FrPlayerGStatsPenalty.Add("Cam WardCAR","D");
FrPlayerGStatsPenalty.Add("Kevin WeekesCAR","D");
FrPlayerGStatsPenalty.Add("Sergei BobrovskyCBJ","D");
FrPlayerGStatsPenalty.Add("Marc DenisCBJ","D");
FrPlayerGStatsPenalty.Add("Pascal LeclaireCBJ","D");
FrPlayerGStatsPenalty.Add("Steve MasonCBJ","D");
FrPlayerGStatsPenalty.Add("Ed BelfourCHI","A");
FrPlayerGStatsPenalty.Add("Corey CrawfordCHI","D");
FrPlayerGStatsPenalty.Add("Tony EspositoCHI","D");
FrPlayerGStatsPenalty.Add("Glenn HallCHI","D");
FrPlayerGStatsPenalty.Add("David AebischerCOL","D");
FrPlayerGStatsPenalty.Add("Peter BudajCOL","D");
FrPlayerGStatsPenalty.Add("Patrick RoyCOL","C");
FrPlayerGStatsPenalty.Add("Semyon VarlamovCOL","D");
FrPlayerGStatsPenalty.Add("Ed BelfourDAL","C");
FrPlayerGStatsPenalty.Add("Kari LehtonenDAL","D");
FrPlayerGStatsPenalty.Add("Andy MoogDAL","B");
FrPlayerGStatsPenalty.Add("Marty TurcoDAL","C");
FrPlayerGStatsPenalty.Add("Tim CheveldaeDET","D");
FrPlayerGStatsPenalty.Add("Jimmy HowardDET","D");
FrPlayerGStatsPenalty.Add("Chris OsgoodDET","C");
FrPlayerGStatsPenalty.Add("Terry SawchukDET","C");
FrPlayerGStatsPenalty.Add("Grant FuhrEDM","D");
FrPlayerGStatsPenalty.Add("Andy MoogEDM","C");
FrPlayerGStatsPenalty.Add("Bill RanfordEDM","D");
FrPlayerGStatsPenalty.Add("Tommy SaloEDM","D");
FrPlayerGStatsPenalty.Add("Sean BurkeFLA","B");
FrPlayerGStatsPenalty.Add("Roberto LuongoFLA","D");
FrPlayerGStatsPenalty.Add("John VanbiesbrouckFLA","C");
FrPlayerGStatsPenalty.Add("Tomas VokounFLA","D");
FrPlayerGStatsPenalty.Add("Sean BurkeHAR","C");
FrPlayerGStatsPenalty.Add("Mike LiutHAR","D");
FrPlayerGStatsPenalty.Add("Greg MillenHAR","D");
FrPlayerGStatsPenalty.Add("Peter SidorkiewiczHAR","D");
FrPlayerGStatsPenalty.Add("Stephane FisetLAK","D");
FrPlayerGStatsPenalty.Add("Kelly HrudeyLAK","C");
FrPlayerGStatsPenalty.Add("Jonathan QuickLAK","D");
FrPlayerGStatsPenalty.Add("Rogatien VachonLAK","D");
FrPlayerGStatsPenalty.Add("Don BeaupreMNS","B");
FrPlayerGStatsPenalty.Add("Jon CaseyMNS","B");
FrPlayerGStatsPenalty.Add("Cesare ManiagoMNS","D");
FrPlayerGStatsPenalty.Add("Gilles MelocheMNS","D");
FrPlayerGStatsPenalty.Add("Niklas BackstromMNW","D");
FrPlayerGStatsPenalty.Add("Devan DubnykMNW","D");
FrPlayerGStatsPenalty.Add("Manny FernandezMNW","D");
FrPlayerGStatsPenalty.Add("Dwayne RolosonMNW","D");
FrPlayerGStatsPenalty.Add("Ken DrydenMON","D");
FrPlayerGStatsPenalty.Add("Jacques PlanteMON","D");
FrPlayerGStatsPenalty.Add("Carey PriceMON","D");
FrPlayerGStatsPenalty.Add("Patrick RoyMON","C");
FrPlayerGStatsPenalty.Add("Mike DunhamNAS","D");
FrPlayerGStatsPenalty.Add("Chris MasonNAS","D");
FrPlayerGStatsPenalty.Add("Pekka RinneNAS","D");
FrPlayerGStatsPenalty.Add("Tomas VokounNAS","C");
FrPlayerGStatsPenalty.Add("Martin BrodeurNJD","D");
FrPlayerGStatsPenalty.Add("Chico ReschNJD","C");
FrPlayerGStatsPenalty.Add("Cory SchneiderNJD","D");
FrPlayerGStatsPenalty.Add("Chris TerreriNJD","D");
FrPlayerGStatsPenalty.Add("Rick DiPietroNYI","B");
FrPlayerGStatsPenalty.Add("Kelly HrudeyNYI","B");
FrPlayerGStatsPenalty.Add("Chico ReschNYI","D");
FrPlayerGStatsPenalty.Add("Billy SmithNYI","AA");
FrPlayerGStatsPenalty.Add("Eddie GiacominNYR","D");
FrPlayerGStatsPenalty.Add("Henrik LundqvistNYR","D");
FrPlayerGStatsPenalty.Add("Mike RichterNYR","D");
FrPlayerGStatsPenalty.Add("Gump WorsleyNYR","D");
FrPlayerGStatsPenalty.Add("Craig AndersonOTT","D");
FrPlayerGStatsPenalty.Add("Patrick LalimeOTT","D");
FrPlayerGStatsPenalty.Add("Damian RhodesOTT","D");
FrPlayerGStatsPenalty.Add("Ron TugnuttOTT","D");
FrPlayerGStatsPenalty.Add("Brian BoucherPHI","D");
FrPlayerGStatsPenalty.Add("Ron HextallPHI","AA");
FrPlayerGStatsPenalty.Add("Pelle LindberghPHI","D");
FrPlayerGStatsPenalty.Add("Bernie ParentPHI","C");
FrPlayerGStatsPenalty.Add("Ilya BryzgalovPHO","D");
FrPlayerGStatsPenalty.Add("Sean BurkePHO","C");
FrPlayerGStatsPenalty.Add("Nikolai KhabibulinPHO","C");
FrPlayerGStatsPenalty.Add("Mike SmithPHO","C");
FrPlayerGStatsPenalty.Add("Tom BarrassoPIT","A");
FrPlayerGStatsPenalty.Add("MarcAndre FleuryPIT","D");
FrPlayerGStatsPenalty.Add("Denis HerronPIT","C");
FrPlayerGStatsPenalty.Add("Ken WreggetPIT","C");
FrPlayerGStatsPenalty.Add("Dan BouchardQUE","C");
FrPlayerGStatsPenalty.Add("Stephane FisetQUE","D");
FrPlayerGStatsPenalty.Add("Mario GosselinQUE","C");
FrPlayerGStatsPenalty.Add("Ron TugnuttQUE","D");
FrPlayerGStatsPenalty.Add("Arturs IrbeSJS","C");
FrPlayerGStatsPenalty.Add("Martin JonesSJS","D");
FrPlayerGStatsPenalty.Add("Evgeni NabokovSJS","C");
FrPlayerGStatsPenalty.Add("Antti NiemiSJS","D");
FrPlayerGStatsPenalty.Add("Jake AllenSTL","D");
FrPlayerGStatsPenalty.Add("Grant FuhrSTL","D");
FrPlayerGStatsPenalty.Add("Curtis JosephSTL","D");
FrPlayerGStatsPenalty.Add("Mike LiutSTL","D");
FrPlayerGStatsPenalty.Add("Ben BishopTBL","D");
FrPlayerGStatsPenalty.Add("Nikolai KhabibulinTBL","D");
FrPlayerGStatsPenalty.Add("Daren PuppaTBL","D");
FrPlayerGStatsPenalty.Add("Andrei VasilevskiyTBL","D");
FrPlayerGStatsPenalty.Add("Johnny BowerTOR","D");
FrPlayerGStatsPenalty.Add("Turk BrodaTOR","D");
FrPlayerGStatsPenalty.Add("Curtis JosephTOR","D");
FrPlayerGStatsPenalty.Add("Felix PotvinTOR","D");
FrPlayerGStatsPenalty.Add("Richard BrodeurVAN","D");
FrPlayerGStatsPenalty.Add("Dan CloutierVAN","C");
FrPlayerGStatsPenalty.Add("Roberto LuongoVAN","D");
FrPlayerGStatsPenalty.Add("Kirk McLeanVAN","D");
FrPlayerGStatsPenalty.Add("Don BeaupreWAS","B");
FrPlayerGStatsPenalty.Add("Braden HoltbyWAS","D");
FrPlayerGStatsPenalty.Add("Al JensenWAS","C");
FrPlayerGStatsPenalty.Add("Olaf KolzigWAS","D");
FrPlayerGStatsPenalty.Add("Bob EssensaWPG","D");
FrPlayerGStatsPenalty.Add("Brian HaywardWPG","C");
FrPlayerGStatsPenalty.Add("Connor HellebuyckWPG","D");
FrPlayerGStatsPenalty.Add("Ondrej PavelecWPG","D");
	}
	
// --------------- UPDATE FUNCTION ---------------
	void Update() {
		
	}
	
// ---------------------------------------- END: INITIAL FUNCTIONS ----------------------------------------
// ---------------------------------------- START: OTHER FUNCTIONS ----------------------------------------
    
	
// ---------------------------------------- END: OTHER FUNCTIONS ----------------------------------------
}