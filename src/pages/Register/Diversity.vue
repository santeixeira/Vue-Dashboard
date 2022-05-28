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
            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="generoIcon">
                <option
                  v-for="naturalidades in naturalidade"
                  :key="naturalidades.desc"
                  :value="naturalidades.value"
                >
                  {{ naturalidades.desc }}
                </option></SelectRegister
              >
              <SelectRegister :icon="generoIcon">
                <option
                  v-for="generos in genero"
                  :key="generos.desc"
                  :value="generos.value"
                >
                  {{ generos.desc }}
                </option>
              </SelectRegister>
            </div>
            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="pronomeIcon">
                <option
                  v-for="pronomes in pronome"
                  :key="pronomes.desc"
                  :value="pronomes.value"
                >
                  {{ pronomes.desc }}
                </option>
              </SelectRegister>
              <SelectRegister :icon="identidadeIcon">
                <option
                  v-for="identidades in identidade"
                  :key="identidades.desc"
                  :value="identidades.value"
                >
                  {{ identidades.desc }}
                </option>
              </SelectRegister>
            </div>

            <div class="is-flex is-justify-content-space-between">
              <SelectRegister :icon="orientacaoIcon">
                <option
                  v-for="orientacaoes in orientacaoSexual"
                  :key="orientacaoes.desc"
                  :value="orientacaoes.value"
                >
                  {{ orientacaoes.desc }}
                </option>
              </SelectRegister>
              <SelectRegister :icon="etniaIcon">
                <option
                  v-for="etnias in etnia"
                  :key="etnias.desc"
                  :value="etnias.value"
                >
                  {{ etnias.desc }}
                </option></SelectRegister
              >
            </div>
            <TextRegister :placeholder="pcd" :icon="pcdIcon" />
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
import {
  Genero,
  Pronome,
  IdentidadeGenero,
  Etnia,
  Naturalidade,
  OrientacaoSexual
} from "@/utils/index";
export default defineComponent({
  // eslint-disable-next-line vue/multi-word-component-names
  name: "Diversity",
  components: {
    ListBox,
    ButtonsRegister,
    TextRegister,
    SelectRegister
  },
  data() {
    return {
      pcd: "Digite qual sua necessidade especial (caso PCD)",
      pcdIcon: "fas fa-person-walking-with-cane",
      generoIcon: "fas fa-mars-and-venus",
      pronomeIcon: "fas fa-person-half-dress",
      identidadeIcon: "fas fa-star",
      orientacaoIcon: "fas fa-people-pulling",
      etniaIcon: "fas fa-people-group",
      btnAnterior: "anter",
      genero: Genero,
      pronome: Pronome,
      identidade: IdentidadeGenero,
      orientacaoSexual: OrientacaoSexual,
      etnia: Etnia,
      naturalidade: Naturalidade
    };
  },
  methods: {
    avancarPagina() {
      this.$router.push({ name: "Social" });
    },
    voltarPagina() {
      this.$router.push({ name: "Personal" });
    }
  }
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
