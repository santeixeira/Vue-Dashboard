<template>
  <ListBox>
    <div class="forms content">
      <div class="form-content">
        <div class="login-form">
          <div class="title">Diversidade</div>
          <form action="#">
            <span class="text">
              <strong>
                Lorem ipsum dolor sit amet consectetur adipisicing elit. Saepe
                necessitatibus labore excepturi corrupti.
              </strong>
            </span>
            <TextRegister
              :placeholder="naturalidade"
              :icon="naturalidadeIcon"
            />
            <TextRegister :placeholder="pcd" :icon="pcdIcon" />
            <SelectRegister :icon="generoIcon">
              <option value="null" default>Selecione seu gênero</option>
              <option value="Masculino">Masculino</option>
              <option value="Feminino">Feminino</option>
              <option value="Outro">Outro</option>
            </SelectRegister>
            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="pronomeIcon">
                <option value="null" default>Pronome adequado</option>
                <option value="Masculino">Ele</option>
                <option value="Feminino">Ela</option>
                <option value="Outro">Outro</option>
              </SelectRegister>
              <SelectRegister :icon="identidadeIcon">
                <option value="null" default>Identidade de gênero</option>
                <option value="Masculino">Ele</option>
                <option value="Feminino">Ela</option>
                <option value="Outro">Outro</option>
              </SelectRegister>
            </div>

            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="orientacaoIcon">
                <option value="null" default>Orientação sexual</option>
                <option value="Masculino">Ele</option>
                <option value="Feminino">Ela</option>
                <option value="Outro">Outro</option>
              </SelectRegister>
              <SelectRegister :icon="etniaIcon">
                <option value="null" default>Etnia</option>
                <option value="Masculino">Ele</option>
                <option value="Feminino">Ela</option>
                <option value="Outro">Outro</option>
              </SelectRegister>
            </div>
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
import ListBox from "@/components/Listas/ListBox.vue";
import ButtonsRegister from "@/components/Utils/ButtonsRegister.vue";
import TextRegister from "@/components/Utils/TextRegister.vue";
import SelectRegister from "@/components/Utils/SelectRegister.vue";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Diversity",
  components: {
    ListBox,
    ButtonsRegister,
    TextRegister,
    SelectRegister,
  },
  data() {
    return {
      naturalidade: "Digite sua naturalidade",
      naturalidadeIcon: "fas fa-flag",
      pcd: "Dgite qual sua necessidade especial (caso PCD)",
      pcdIcon: "fas fa-person-walking-with-cane",
      genero: "Test",
      generoIcon: "fas fa-mars-and-venus",
      pronomeIcon: "fas fa-person-half-dress",
      identidadeIcon: "fas fa-star",
      orientacaoIcon: "fas fa-people-pulling",
      etniaIcon: "fas fa-people-group",
      btnAnterior: "anter",
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Social" });
    },
    voltarPagina() {
      this.$router.push({ name: "Personal" });
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
  height: 45em;
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
