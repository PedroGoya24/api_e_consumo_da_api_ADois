import CardHome from "../components/CardHome"
import 'bootstrap/dist/css/bootstrap.css'
import styles from './RotaUm.module.css'

export default function RotaUm() {
  return (
    <>
      <main className='container'>
        {/*Inicio Form*/}
        <form className={styles.formulario}>
          <div className="row mb-3">
            <div className="col-md d-flex justify-content-center">
              <div className="p-3">
                <h2>Viagens para dois</h2>
              </div>
            </div>
            {/*Botões*/}
            <div
              className="btn-group col-md btnForm"
              role="group"
              aria-label="Basic radio toggle button group"
            >
              <input
                type="radio"
                className="btn-check"
                name="btnradio"
                id="btnradio1"
                autoComplete="off"
                defaultChecked=""
              />
              <label className="btn btn-outline-dark" htmlFor="btnradio1">
                Ida e Volta
              </label>
              <input
                type="radio"
                className="btn-check"
                name="btnradio"
                id="btnradio3"
                autoComplete="off"
              />
              <label className="btn btn-outline-dark" htmlFor="btnradio3">
                Somente Ida
              </label>
            </div>
            {/*Reais/Milhas*/}
            <div className="radio col-md p-4 d-flex justify-content-evenly">
              <h5 className="mr-1">Exibir em:</h5>
              <div className="form-check ml-1">
                <input
                  className="form-check-input"
                  type="radio"
                  name="flexRadioDefault"
                  id="flexRadioDefault1"
                />
                <label className="form-check-label" htmlFor="flexRadioDefault1">
                  Reais
                </label>
              </div>
              <div className="form-check">
                <input
                  className="form-check-input"
                  type="radio"
                  name="flexRadioDefault"
                  id="flexRadioDefault2"
                  defaultChecked=""
                />
                <label className="form-check-label" htmlFor="flexRadioDefault2">
                  Reais + Milhas
                </label>
              </div>
            </div>
          </div>
          {/*Local de ida*/}
          <div className="row">
            <div className="mb-3 col-md">
              <label htmlFor="exampleInputEmail1" className="form-label">
                Local de Ida
              </label>
              <input
                type="name"
                className="form-control"
                id="exampleInputEmail1"
                aria-describedby="emailHelp"
              />
            </div>
            <div className="mb-3 col-md ">
              <label htmlFor="exampleInputPassword1" className="form-label">
                Local do destino
              </label>
              <input
                type="password"
                className="form-control"
                id="exampleInputPassword1"
              />
            </div>
            <div className="mb-3 col-md ">
              <label htmlFor="validationCustomUsername" className="form-label">
                Data de ida
              </label>
              <div className="input-group has-validation">
                <input
                  type="date"
                  className="form-control"
                  id="validationDataIda"
                  aria-describedby="inputGroupPrepend"
                  required=""
                />
              </div>
            </div>
            <div className=" mb-3 col-md">
              <label htmlFor="validationCustomUsername" className="form-label">
                Data de volta
              </label>
              <div className="input-group has-validation">
                <input
                  type="date"
                  className="form-control"
                  id="validationDataVolta"
                  aria-describedby="inputGroupPrepend"
                  required=""
                />
              </div>
            </div>
            <div className="mb-3 com-md form-check">
              <button className="btn btn-primary" type="submit">
                Pesquisar
              </button>
            </div>
          </div>
        </form>
        {/*Fim Form*/}

        {/*Inicio Card Sazonal*/}
        <div class="container row mx-auto d-flex justify-content-evenly">
          <h1 className={styles.title}>
            Navegue pelos nossos pacotes sazonais
          </h1>

          <CardHome
            imagem="/VeraoADois.png"
            titulo="Verão 🌞❤️"
            texto="Desfrute de momentos inesquecíveis em
                 destinos paradisíacos. Seja em piscinas refrescantes, praia de águas cristalinas, à
                 beira de lagos ou explorando parques exuberantes, cada cenário é uma oportunidade para
                 se conectar e fortalecer o amor."
          />
          <CardHome
            imagem="/InvernoADois.png"
            titulo="Inverno ❄️❤️"
            texto="Perfeito para desfrutar de aconchego e
            romance. Com lareiras e jantares à luz de velas, o frio torna-se uma oportunidade para
            se hospedar em lindos hoteis e relaxar em spas acolhedores. Viva momentos de pura
            intimidade nesta temporada mágica!"
          />
          <CardHome
            imagem="/OutonoADois.png"
            titulo="Outono 🍂❤️"
            texto="Perfeito para caminhadas românticas por
            florestas coloridas, tardes tranquilas em cafés e
            pôres do sol espetaculares em chalés. Embarque em uma
            viagem a dois nesta época mágica e vivencie momentos inesquecíveis juntos!"
          />
          <CardHome
            imagem="/PrimaveraADois.png"
            titulo="Primavera 🌸❤️"
            texto="Apaixone-se em meio à renovação da
            natureza. Caminhe
            por jardins floridos, desfrute de piqueniques românticos em parques
            repletos de cores e sinta o perfume das flores no ar. O clima ameno e a atmosfera
            romântica da primavera criam momentos inesquecíveis para apaixonados."
          />
        </div>
        {/*Fim Card Sazonal*/}


        {/*Promoções/Ofertas*/}
        <section className={styles.ofertas}>
          <form className="row ">
            <div className="d-flex justify-content-center w-100">
              <h2>Inscreva-se para receber promoções exclusivas</h2>
            </div>
            <div className="row d-flex justify-content-center">
              <div className="col-auto">
                <label htmlFor="inputName" className="visually-hidden">
                  Nome
                </label>
                <input
                  type="text"
                  className="form-control"
                  placeholder="Nome"
                  aria-label="Nome"
                />
              </div>
              <div className="col-auto">
                <input
                  type="email"
                  className="form-control"
                  id="exampleFormControlInput1"
                  placeholder="Escreva seu e-mail"
                />
              </div>
              <div className="col-auto">
                <button type="submit" className="btn btn-outline-success mb-3">
                  TO DENTRO
                </button>
              </div>
            </div>
          </form>
        </section>
        {/*Promoções/Ofertas*/}
      </main>



      <div className="container">
        <h2 className="mb-3" style={{ textAlign: "center" }}>
          Dúvidas frequentes
        </h2>
        <div className="row mb-3 gap-4 justify-content-center">
          <div className="card" style={{ width: "25rem", border: "none" }}>
            <div className="card-body ">
              <h5 className="card-title" style={{ textAlign: "center" }}>
                Como funciona a A Dois TRIP?
              </h5>
              <p className="card-text" style={{ alignItems: "left" }}>
                Somos uma plataforma exclusiva que focaliza a sua viagem a dois,
                romântica e prazerora, pelo melhor preço. É te levando a lugares que
                despertam a paixão e acendem o fogo do amor que lucramos.{" "}
              </p>
            </div>
          </div>
          <div className="card" style={{ width: "25rem", border: "none" }}>
            <div className="card-body ">
              <h5 className="card-title" style={{ textAlign: "center" }}>
                É seguro comprar na A Dois TRIP?
              </h5>
              <p className="card-text" style={{ alignItems: "left" }}>
                Na A Dois TRIP, sua segurança é nossa prioridade. Implementamos
                rigorosas medidas de proteção para suas informações pessoais e
                financeiras, utilizando tecnologias de segurança avançadas para
                criptografar todas as transações. Trabalhamos somente com parceiros
                confiáveis do setor do turismo, garantindo serviços excelentes e
                proteção em todas as etapas da sua experiência conosco.
              </p>
            </div>
          </div>
          <div className="card" style={{ width: "25rem", border: "none" }}>
            <div className="card-body ">
              <h5 className="card-title" style={{ textAlign: "center" }}>
                Tem reembolso na A dois TRIP?
              </h5>
              <p className="card-text" style={{ alignItems: "left" }}>
                Com uma tolerância de até 10 dias úteis antes da viagem, oferecemos a
                oportunidade de reembolso da compra e o cancelamento da mesma.{" "}
              </p>
            </div>
          </div>
        </div>
      </div>

    </>
  )
}