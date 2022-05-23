<template>
  <ListBox>
    <div class="columns">
      <div class="column is-3">
        <a @click="isOpen = true">Adicione carreira</a>
        <Modal :open="isOpen" @close="isOpen = !isOpen">
          <Job></Job>
        </Modal>
      </div>
    </div>
  </ListBox>
  <ListBox v-if="listVoid">
    <img
      src="https://img.freepik.com/free-vector/self-made-businessman-career-ladder-personal-improvement-new-opportunity-man-with-cubes-building-stairs-business-growth-strategy-development-vector-isolated-concept-metaphor-illustration_335657-2717.jpg?w=826&t=st=1652543434~exp=1652544034~hmac=8b021c10ad913b4c326b52d72df1b7a1f5c72a1d4b2e18ac94ef37cbe269985c"
      alt=""
      id="imgNonData"
    />
    <h1 id="txtNonData">Você não foi possivel retornar recomendações</h1>
  </ListBox>
  <MainList v-for="(dev, index) in devs" :key="index" :dev="dev" />
</template>

<script lang="ts">
import { defineComponent, ref } from "vue";
import devs from "../interface/devs";
import MainList from "../components/Listas/MainList.vue";
import ListBox from "../components/Listas/ListBox.vue";
import Modal from "@/components/Utils/Modal.vue";
import Job from "@/components/Register/Job.vue";

export default defineComponent({
  name: "DashBoard",
  components: {
    MainList,
    ListBox,
    Modal,
    Job,
  },
  data() {
    return {
      devs: [] as devs[],
    };
  },
  computed: {
    listVoid(): boolean {
      return this.devs.length === 0;
    },
  },
  setup() {
    const isOpen = ref(false);
    return { isOpen };
  },
});
</script>
