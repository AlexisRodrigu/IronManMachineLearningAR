using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System;
using Newtonsoft.Json;

//Custom 8
public partial class Wit3D : MonoBehaviour
{

    public Text myHandleTextBox;
    private bool actionFound = false;
	public IronMan ironMan;

    void Handle(string jsonString)
    {

        if (jsonString != null)
        {

            RootObject theAction = new RootObject();
            Newtonsoft.Json.JsonConvert.PopulateObject(jsonString, theAction);

            if (theAction.entities.inicio != null)
            {
                foreach (Inicio aPart in theAction.entities.inicio)
                {
                    Debug.Log(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
					ironMan.Saludo();
                }
            }
            if (theAction.entities.activar != null)
            {
                foreach (Activar aPart in theAction.entities.activar)
                {
                    Debug.Log(aPart.value);
                    myHandleTextBox.text = aPart.value;
                    actionFound = true;
					
					ironMan.Armar();
                }
            }

            if (!actionFound)
            {
                myHandleTextBox.text = "Request unknown, please ask a different way.";
            }
            else
            {
                actionFound = false;
            }

        }//END OF IF

    }//END OF HANDLE VOID

}//END OF CLASS


//Custom 9
public class Inicio
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Activar
{
    public bool suggested { get; set; }
    public double confidence { get; set; }
    public string value { get; set; }
    public string type { get; set; }
}

public class Entities
{
    public List<Inicio> inicio { get; set; }
    public List<Activar> activar { get; set; }
}

public class RootObject
{
    public string _text { get; set; }
    public Entities entities { get; set; }
    public string msg_id { get; set; }
}