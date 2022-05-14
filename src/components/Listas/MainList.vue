<template>
  <ListBox>
    <div class="columns" id="1">
      <div class="column is-1" role="form" aria-label="Adicao de posts">
        <img class="avatar" src="../../assets/foo1.jpg" alt="avatar" />
      </div>
      <div class="column is-2">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="titulo-candidato">Desenvolvedor</span>
          </section>
        </div>
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="txtNome">{{dev.nome}}</span>
          </section>
        </div>
      </div>
      <div class="column is-2">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="titulo-candidato">Habilidades</span>
          </section>
        </div>

        <div class="is-flex is-align-items-center">
          <ul class="tags">
            <li class="tag">
              <span>{{dev.habilidades[0]}}</span>
            </li>
            <li class="tag">
              <span>{{dev.habilidades[1]}}</span>
            </li>
          </ul>
        </div>
      </div>
      <div class="column is-2">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="titulo-candidato">Tecnologias</span>
          </section>
        </div>
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <ul>
              <li>
                <img
                  src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/docker/docker-plain.svg"
                />
              </li>
              <li>
                <img
                  src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/flutter/flutter-plain.svg"
                />
              </li>
              <li>
                <img
                  src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/swift/swift-original.svg"
                />
              </li>
              <li>
                <img
                  src="https://cdn.jsdelivr.net/gh/devicons/devicon/icons/vuejs/vuejs-original.svg"
                />
              </li>
            </ul>
          </section>
        </div>
      </div>
      <div class="column is-2">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="titulo-candidato">Modalidade</span>
          </section>
        </div>
        <div class="is-flex is-align-items-center">
          <ul class="tags">
            <li class="tag">
              <span>{{dev.modalidade[0]}}</span>
            </li>
            <li class="tag">
              <span>{{dev.modalidade[1]}}</span>
            </li>
          </ul>
        </div>
      </div>
      <div class="column is-2">
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section>
            <span id="titulo-candidato">Experiências</span>
          </section>
        </div>
        <div
          class="is-flex is-align-items-center is-justify-content-space-between"
        >
          <section class="tag is-success">
            <span id="txtNome">{{dev.experiencias[0] || "Primeira oportunidade"}}</span>
          </section>
        </div>
      </div>
      <div class="column is-1">
        <button class="button">
          <span class="icon">
            <i class="fas fa-ellipsis-vertical"></i>
          </span>
        </button>
      </div>
    </div>
  </ListBox>
</template>

<script lang="ts">
import devs from "../../interface/devs";
import ListBox from "./ListBox.vue";
import { defineComponent, PropType } from "vue";

export default defineComponent({
  name: "MainList",
  components: { ListBox },
  props: {
    dev: {
      type: Object as PropType<devs>,
      required: true,
    }
  },
})
</script>

<style>
@import url("./style.scss");
</style>
