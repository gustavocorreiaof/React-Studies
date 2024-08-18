import React from "react";

import "./App.css"
import First from './Components/Basics/FirstComponent'
import ComParametro from './Components/Basics/ComParametro'
import Fragmento from './Components/Basics/Fragmento'
import Aleatorio from "./Components/Basics/Aleatorio";
import Card from "./Components/Basics/Layout/Card";
import Familia from "./Components/Basics/Familia";

export default props => {
    return (

        <div id="app">
            
            <div className="Cards">

            <Card titulo="Componente com filho">
                <Familia></Familia>
            </Card>

            <Card titulo="Exercicio Numero Aleatorio" color="red">
                <Aleatorio x={0} y={100}></Aleatorio>
            </Card>

            <Card titulo="Primeiro Componente" color="green">
                <First></First>
            </Card>

            <Card titulo="Fragmento" color="blue">
                <Fragmento></Fragmento>
            </Card>

            <Card titulo="Com parametro">
                <ComParametro titulo="Componenteaa com Parametro" subtitulo="Primeiro Componente com parametro"></ComParametro>
            </Card>

            </div>

        </div>

    )
}