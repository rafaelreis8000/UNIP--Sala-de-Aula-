import flet as ft


def main(page: ft.page):

    def tecla(e: ft.KeyboardEvent):
        page.add(

            ft.Text(f"Tecla pressionada: {e.key}, Shift: {e.shift}, Alt: {e.alt}, Meta: {e.meta}") #meta é a tecla do windows

        )
    
    page.on_keyboard_event= tecla #passsa os eventos para o "e"
    page.add(

        ft.Text("Pressione qualquer tecla")

    )

ft.app(target= main)