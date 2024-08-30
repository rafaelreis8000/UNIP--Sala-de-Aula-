#criação de listas com listview

import flet as ft

def main(page: ft.Page):
    lista = ft.ListView(spacing= 2, expand= True) #expand permite usar o scroll

    for i in range(100):
        lista.controls.append(ft.Text(f"Estamos na linha: {i}"))

    page.add(lista)

ft.app(target= main, view= ft.WEB_BROWSER)