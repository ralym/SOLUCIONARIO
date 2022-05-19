# -*- coding: utf-8 -*-
"""
Created on Tue May 17 17:14:47 2022

@author: RAUL
"""
from pyswip import Prolog
prolog = Prolog()

prolog.assertz("hermano(raul,ruth)")
prolog.assertz("primo(sara,raul)")
prolog.assertz("primo(sara,ruth)")
prolog.assertz("abuelo(juan,raul)")
prolog.assertz("abuelo(juan,sara)")
prolog.assertz("abuelo(juan,ruth)")
prolog.assertz("abuelo(juan,julio)")

#list(prolog.query("hermano(juan,X)"))==[{"X":"raul"},{"Y":"juan"}]

    
for elemento in prolog.query("abuelo(X,Y)"):
    print(elemento["X"], "es el abuelo de ",elemento["Y"])
    
for elemento in prolog.query("hermano(X,Y)"):
    print(elemento["X"], "es el hermano de ",elemento["Y"])
    
for elemento in prolog.query("primo(X,Y)"):
    print(elemento["X"], "es el primo de ",elemento["Y"])