import React from "react";
import alunos from "../../data/alunos";

export default props => {

    const lis = alunos.map((aluno) => {
        return (
            <li>
                {aluno.Id} {aluno.nome}  {aluno.nota}
            </li>
        )
    })

    console.log(lis)

    return (

        <div>
            <ul>
                {lis}
            </ul>
        </div>

    )

}