import React from "react";
import produtos from "../../data/produtos";

export default props => {

    const lis = alunos.map((aluno) => {
        return (
            <li>
                {aluno.Id} {aluno.nome}  {aluno.nota}
            </li>
        )
    })

    return (

        <div>
            <ul>
                {lis}
            </ul>
        </div>

    )

}