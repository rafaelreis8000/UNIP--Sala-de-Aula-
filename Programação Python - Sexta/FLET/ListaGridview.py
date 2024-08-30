"lista de itens usando gridview e linhas (row)"

import os
import flet as ft

os.environ ["FLET_WS_MAX_MESSAGE_SIZE"] = "8000000"    #estanciou OS permitindo que a aplicação leia muitos itens

def main(page: ft.page):
    linha= ft.Row(wrap= True, scroll= "always", expand= True) #wrap não deixa os containers vazarem da tela. Expand permite que a função scroll role a tela
    page.add(linha)

    for i in range(10): #lista 100 itens, que vão de 0 até 99
        linha.controls.append(
            ft.Container(

                ft.Text(f"Itenm {i}"),
                width= 100,
                height= 100,
                alignment= ft.alignment.center,
                bgcolor= ft.colors.AMBER_100,
                border= ft.border.all(2, ft.colors.AMBER_600),
                border_radius= ft.border_radius.all(8)

            )
        )
    
    page.update()

ft.app(target= main, view= ft.WEB_BROWSER)