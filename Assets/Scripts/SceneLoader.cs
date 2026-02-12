using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
public void LoadTitle()
{
SceneManager.LoadScene("Title");
}

public void LoadAbstraction()
{
SceneManager.LoadScene("Abstraction");
}

public void LoadInheritance()
{
SceneManager.LoadScene("Inheritance");
Debug.Log("loaded inheritance");
}

public void LoadPolymorphism()
{
SceneManager.LoadScene("Polymorphism");
Debug.Log("loaded Polymorphism");
}

public void LoadEncapsulation()
{
SceneManager.LoadScene("Encapsulation");
}

public void QuitGame()
{
Application.Quit();
}
}