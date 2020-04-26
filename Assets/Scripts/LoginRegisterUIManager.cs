using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[RequireComponent(typeof(UsersManager))]
public class LoginRegisterUIManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI userName;
    [SerializeField] private TextMeshProUGUI password;
    [SerializeField] private Button RegisterButton;

    private UsersManager usersManager;

    private void Start()
    {
        usersManager = gameObject.GetComponent<UsersManager>();

        RegisterButton.onClick.AddListener(Register);
    }

    public void Register()
    {
        User user = new User(userName.text, password.text);
        usersManager.WriteUserData(user);
    }
}
