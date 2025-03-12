using System.Collections.Generic;
using System.Runtime.InteropServices;
using UnityEngine;

public class ChooseCommand : ICommand
{
    public List<ICommand> commands;
    public override void Invoke()
    {
        int randomNumber = Random.Range(0, commands.Count);
        commands[randomNumber].Invoke();
    }
}
