using Assets.Custom.Scripts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

namespace Assets.Custom.UI
{
    class FormationSelection : MonoBehaviour
    {
        GameManager gameManager;

        Dropdown m_Dropdown;

        Dictionary<string, int> options;

        void Start()
        {
            options = new Dictionary<string, int>();
            options.Add("4-4-2", 0);
            options.Add("4-3-3", 1);
            options.Add("4-2-3-1", 2);
            gameManager = GameManager.Instance;
            //Fetch the Dropdown GameObject
            m_Dropdown = GetComponent<Dropdown>();
            m_Dropdown.value = options[gameManager._Formation.FormationCode];
            //Add listener for when the value of the Dropdown changes, to take action
            m_Dropdown.onValueChanged.AddListener(delegate {
                DropdownValueChanged(m_Dropdown);
            });
        }

        public void DropdownValueChanged(Dropdown change)
        {
            //GameObject.Find("FormationDropdown");
            if (change.options[change.value].text.Equals("4-4-2"))
            {
                gameManager._Formation = new Formation_442();
            } else if(change.options[change.value].text.Equals("4-3-3"))
            {
                gameManager._Formation = new Formation_433();
            } else
            {
                gameManager._Formation = new Formation_4231();
            }
            gameManager._Formation.UpdatePlayers();
        }

    }
}
