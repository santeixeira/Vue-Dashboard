<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Pessoal</div>
          <form action="#">
            <TextRegister :placeholder="nome" :icon="nomeIcon" />
            <div class="is-flex is-justify-content-space-between">
              <TextRegister :placeholder="dtNascimento" :icon="dtNascimentoIcon" />
              <TextRegister :placeholder="telefone" :icon="telefoneIcon" />
            </div>

            <TextRegister :placeholder="endereco" :icon="enderecoIcon" />

            <span class="text">
              <strong>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Saepe
                necessitatibus labore excepturi corrupti.
              </strong>
            </span>
            <TextRegister :placeholder="linkedIn" :icon="linkedInIcon" />
            <TextRegister :placeholder="github" :icon="githubIcon" />
            <TextRegister :placeholder="site" :icon="siteIcon" />
          </form>
        </div>
      </div>
    </div>
    <div class="input-box is-flex button-space-between">
      <ButtonsRegister @click="voltarPagina" :class="btnAnterior"
        >Anterior</ButtonsRegister
      >
      <ButtonsRegister @click="avancarPagina">Next</ButtonsRegister>
    </div>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import ListBox from "../Listas/ListBox.vue";
import ButtonsRegister from "../Utils/ButtonsRegister.vue";
import TextRegister from "../Utils/TextRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Personal",
  components: {
    ListBox,
    ButtonsRegister,
    TextRegister,
  },
  data() {
    return {
      nome: "Digite o seu nome completo",
      nomeIcon: "fas fa-user",
      linkedIn: "Digite o link de seu perfil LinkedIn",
      linkedInIcon: "fa-brands fa-linkedin",
      github: "Digite o link de seu perfil Github",
      githubIcon: "fa-brands fa-github",
      site: "Digite o link do seu site (se tiver)",
      siteIcon: "fas fa-at",
      dtNascimento: "Digite sua data de nasc.",
      dtNascimentoIcon: "fas fa-calendar",
      telefone: "Digite seu telefone",
      telefoneIcon: "fas fa-phone",
      endereco: "Digite seu endereço completo",
      enderecoIcon: "fas fa-location-dot",
      btnAnterior: "anter",
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Diversity" });
    },
    voltarPagina() {
      this.$router.push({ name: "Credentials" });
    },
  },
});
</script>



<style scoped>
@import url("Primary.scss");

.button-space-between {
  justify-content: space-between;
}
.box {
  margin: 2em 20em 10em;
  height: 50em;
}
.content-dev {
  margin: 0em 1em 0;
}
.title-dev {
  margin: 3em;
}

.input-box {
  margin: 0 0 2em !important;
}

.input::placeholder {
  font-size: small;
  font-weight: 700;
}

.input,
.textarea,
select {
  width: 25em;
}

li {
  margin-right: 1.75em;
}

.anter {
  background-color: #051c27;
}

.anter:hover {
  border: 2px solid #051c27;
  background: none;
  color: #051c27;
}
</style>
