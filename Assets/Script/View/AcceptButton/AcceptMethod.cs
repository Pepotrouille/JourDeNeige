using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AcceptMethod : MonoBehaviour
{
    public enum TypeAcceptMethod {TAKESHOWER, OPENVENT, TAKETOOLBOX, TAKESCARF, GOOUT, OPENCLOSET, TAKELEFTBOOT, TAKERIGHTBOOT }
    public virtual void Accept()
    {    }
}
