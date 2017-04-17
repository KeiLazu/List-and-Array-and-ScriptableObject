using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListCharacters
{

    protected string _nameChara;
    protected int _powerChara;

    public string get_nameChara
    {
        get { return _nameChara; }
        set { _nameChara = value; }
    }

    public int get_powerChara
    {
        get { return _powerChara; }
        set { _powerChara = value; }
    }

    public ListCharacters()
    {
        //i kindly call this one "zeroing"
    }

    public ListCharacters(string nameChara, int powerChara)
    {

        _nameChara = nameChara;
        _powerChara = powerChara;
    }

}
