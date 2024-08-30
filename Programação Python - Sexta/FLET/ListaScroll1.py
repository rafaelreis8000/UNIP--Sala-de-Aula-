#lista de itens usando scroll método 1

import flet as ft

def main(page: ft.Page):
    for i in range (100):
        page.controls.append(ft.Text(f"Estamos na linha {i}"))

    page.scroll = "always"
    page.update()

ft.app(target= main, view=ft.WEB_BROWSER)