using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class question : MonoBehaviour
{
  [SerializeField] Text questionText;
  [SerializeField] string elementName;
  [SerializeField] private string[] m_InspectorStrings;
  [SerializeField] private string[] m_HardCodedStrings;

  private void Awake() 
  {
  m_HardCodedStrings = new string[]
  {
    "Hydrogen",
    "Helium",
    "Lithium",
    "Beryllium",
    "Boron",
    "Carbon",
    "Nitrogen",
    "Oxygen",
    "Fluorine",
    "Neon",
    "Sodium",
    "Magnesium",
    "Aluminum",
    "Silicon",
    "Phosphorus",
    "Sulfur",
    "Chlorine",
    "Argon",
    "Potassium",
    "Calcium",
    "Scandium",
    "Titanium",
    "Vanadium",
    "Chromium",
    "Manganese",
    "Iron",
    "Cobalt",
    "Nickel",
    "Copper",
    "Zinc",
    "Gallium",
    "Germanium",
    "Arsenic",
    "Selenium",
    "Bromine",
    "Krypton",
    "Rubidium",
    "Strontium",
    "Yttrium",
    "Zirconium",
    "Niobium",
    "Molybdenum",
    "Technetium",
    "Ruthenium",
    "Rhodium",
    "Palladium",
    "Silver",
    "Cadmium",
    "Indium",
    "Tin",
    "Antimony",
    "Tellurium",
    "Iodine",
    "Xenon",
    "Cesium",
    "Barium",
    "Lanthanum",
    "Cerium",
    "Praseodymium",
    "Neodymium",
    "Promethium",
    "Samarium",
    "Europium",
    "Gadolinium",
    "Terbium",
    "Dysprosium",
    "Holmium",
    "Erbium",
    "Thulium",
    "Ytterbium",
    "Lutetium",
    "Hafnium",
    "Tantalum",
    "Tungsten",
    "Rhenium",
    "Osmium",
    "Iridium",
    "Platinum",
    "Gold",
    "Mercury",
    "Thallium",
    "Lead",
    "Bismuth",
    "Polonium",
    "Astatine",
    "Radon",
    "Francium",
    "Radium",
    "Actinium",
    "Thorium",
    "Protactinium",
    "Uranium",
    "Neptunium",
    "Plutonium",
    "Americium",
    "Curium",
    "Berkelium",
    "Californium",
    "Einsteinium",
    "Fermium",
    "Mendelevium",
    "Nobelium",
    "Lawrencium",
    "Rutherfordium",
    "Dubnium",
    "Seaborgium",
    "Bohrium",
    "Hassium",
    "Meitnerium",
    "Darmstadtium",
    "Roentgenium",
    "Copernicium",
    "Nihonium",
    "Flerovium",
    "Moscovium",
    "Livermorium",
    "Tennessine",
    "Oganesson",    
  }; 
  }
    void Start()
    {
      elementName = "Lithium"; 
    }

    void Update()
    {
      if(Input.GetMouseButtonDown(0))
      {
        questionText.text = "Where is the element " + AskQuestion() + "?";
        // if button pressed matches elementNumberAsked()
        // if correct run Correct()
        // if incorrect run Incorrect()
      }
    }

    string AskQuestion()
    {
      int elementNumberAsked = PickNewElementNumber();
      string elementNameAsked = GetRandomHardCodedString(elementNumberAsked);
      return elementNameAsked;
    }

    public int PickNewElementNumber()
    {
      int num = Random.Range(0, 117);
      return num;
    }

   public string GetRandomHardCodedString(int num)
     {

         return m_HardCodedStrings[num];
     }

     public void Correct()
     {

     }

     public void Incorrect()
     {

     }

}
