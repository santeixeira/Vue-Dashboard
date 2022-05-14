<template>
  <ListBox>
    <div class="columns">
      <div class="column is-2">
        <input type="text" class="input" />
      </div>
    </div>
  </ListBox>
  <MainList v-for="(dev, index) in devs" :key="index" :dev="dev" />
  <ListBox v-if="listVoid">
    <img
      src="https://img.freepik.com/free-vector/self-made-businessman-career-ladder-personal-improvement-new-opportunity-man-with-cubes-building-stairs-business-growth-strategy-development-vector-isolated-concept-metaphor-illustration_335657-2717.jpg?w=826&t=st=1652543434~exp=1652544034~hmac=8b021c10ad913b4c326b52d72df1b7a1f5c72a1d4b2e18ac94ef37cbe269985c"
      alt=""
      id="imgNonData"
    />
    <h1 id="txtNonData">Você não foi possivel retornar recomendações</h1>
  </ListBox>
</template>

<script lang="ts">
import { defineComponent } from "vue";
import devs from "../../interface/devs";
import MainList from "../Listas/MainList.vue";
import ListBox from "../Listas/ListBox.vue";
export default defineComponent({
  name: "FormPost",
  components: { MainList, ListBox },
  computed: {
    listVoid(): boolean {
      return this.devs.length === 0;
    },
  },
  data() {
    return {
      devs: [] as devs[],
    };
  },
});
</script>

<style>
  @import url("./style.scss");
</style>
