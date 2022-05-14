<template>
  <div class="box">
    <div class="columns">
      <div class="column is-2">
        <input type="text" class="input" />
      </div>
    </div>
  </div>
  <div class="box">
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
            <span id="txtNome">santeixeira</span>
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
          <div class="tag column is-3">
            <span id="txtTag2">Mobile</span>
          </div>
          <div class="tag column is-3">
            <span id="txtTag">DevOps</span>
          </div>
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
        <div
          class="is-flex is-align-items-center"
        >
          <div class="tag">
            <span id="txtNome">Remoto</span>
          </div>
          <div class="tag">
            <span id="txtNome">Híbrido</span>
          </div>
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
            <span id="txtNome">Primeira Oportunidade</span>
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
  </div>
</template>

<script lang="ts">
import { defineComponent } from "vue";
export default defineComponent({
  name: "FormPost",
  // methods: {
  //   // expand () {

  //   // }
  // }
});
</script>

<style>
@import url("./style.scss");
</style>
